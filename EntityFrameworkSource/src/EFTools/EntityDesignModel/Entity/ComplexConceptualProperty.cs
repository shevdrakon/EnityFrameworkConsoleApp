﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.Data.Entity.Design.Model.Entity
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Xml.Linq;

    internal class ComplexConceptualProperty : Property
    {
        // is used when creating default names for Complex Properties - always the same is every language so not localized 
        internal const string DefaultComplexPropertyName = "ComplexProperty";

        private SingleItemBinding<ComplexType> _complexTypeAttr;

        internal ComplexConceptualProperty(EFElement parent, XElement element)
            : this(parent, element, null)
        {
        }

        /// <summary>
        ///     Allow the construction of a complex property at a specified position.
        /// </summary>
        /// <param name="parent">Property's Parent</param>
        /// <param name="element">Property's XElement</param>
        /// <param name="insertPosition">Information where the property should be inserted to. If the parameter is null, the property will be placed as the last property of the entity.</param>
        internal ComplexConceptualProperty(EFElement parent, XElement element, InsertPropertyPosition insertPosition)
            : base(parent, element, insertPosition)
        {
            Debug.Assert(
                parent is ConceptualEntityType || parent is ComplexType || parent == null,
                "Parent of ConceptualProperty should be either ConceptualEntityType or ComplexType (or null for testing)");
        }

        internal override string TypeName
        {
            get
            {
                if (ComplexType.Status == BindingStatus.Known)
                {
                    return ComplexType.Target.LocalName.Value;
                }
                else
                {
                    // only show the last part of the name (without namespace)
                    return ComplexType.RefName.Substring(ComplexType.RefName.LastIndexOf(Symbol.VALID_RUNTIME_SEPARATOR) + 1);
                }
            }
        }

        internal SingleItemBinding<ComplexType> ComplexType
        {
            get
            {
                if (_complexTypeAttr == null)
                {
                    _complexTypeAttr = new SingleItemBinding<ComplexType>(
                        this,
                        AttributeType,
                        EFNormalizableItemDefaults.DefaultNameNormalizerForEDM);
                }

                return _complexTypeAttr;
            }
        }

        protected override DefaultableValue<string> GetStoreGeneratedPatternDefaultableValue()
        {
            return new StoreGeneratedPatternForCsdlDefaultableValue(this);
        }

        protected override void PreParse()
        {
            Debug.Assert(State != EFElementState.Parsed, "this object should not already be in the parsed state");

            ClearEFObject(_complexTypeAttr);
            _complexTypeAttr = null;

            base.PreParse();
        }

        // we unfortunately get a warning from the compiler when we use the "base" keyword in "iterator" types generated by using the
        // "yield return" keyword.  By adding this method, I was able to get around this.  Unfortunately, I wasn't able to figure out
        // a way to implement this once and have derived classes share the implementation (since the "base" keyword is resolved at 
        // compile-time and not at runtime.
        private IEnumerable<EFObject> BaseChildren
        {
            get { return base.Children; }
        }

        internal override IEnumerable<EFObject> Children
        {
            get
            {
                foreach (var efobj in BaseChildren)
                {
                    yield return efobj;
                }
                yield return ComplexType;
            }
        }

        protected override void DoResolve(EFArtifactSet artifactSet)
        {
            ComplexType.Rebind();
            if (ComplexType.Status == BindingStatus.Known)
            {
                State = EFElementState.Resolved;
            }
        }

        /// <summary>
        ///     Returns an enumerable list of scalar properties. The scalar property is also defined
        ///     by its list of ancestors up to (and including) the given complex property)
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<ReadOnlyCollection<Property>> GetAllNestedScalarProperties()
        {
            var listOfAncestorLists = new List<ReadOnlyCollection<Property>>();
            var initialStack = new Stack<Property>();
            initialStack.Push(this);
            GetAllNestedScalarPropertiesRecurse(listOfAncestorLists, initialStack);
            return listOfAncestorLists;
        }

        private void GetAllNestedScalarPropertiesRecurse(
            List<ReadOnlyCollection<Property>> listOfAncestorLists, Stack<Property> ancestorStack)
        {
            var complexType = ComplexType.Target;
            foreach (var property in complexType.Properties())
            {
                ancestorStack.Push(property);
                var complexProperty = property as ComplexConceptualProperty;
                if (complexProperty != null)
                {
                    complexProperty.GetAllNestedScalarPropertiesRecurse(listOfAncestorLists, ancestorStack);
                }
                else
                {
                    // Still want to push and pop off 'leaf' nodes, but the format of the eventual list should be reversed
                    // so that we can easily create a serialized path for the nested property
                    listOfAncestorLists.Add(new ReadOnlyCollection<Property>(ancestorStack.Reverse().ToList()));
                    ancestorStack.Pop();
                }
            }
        }
    }
}
