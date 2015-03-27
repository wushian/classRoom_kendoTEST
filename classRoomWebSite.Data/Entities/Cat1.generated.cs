﻿#pragma warning disable 1591
// <auto-generated>
//     This code was generated from a CodeSmith Generator template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace classRoomWebSite.Data
{
    [EdmEntityTypeAttribute(NamespaceName="classRoomWebSite.Data", Name="Cat1")]
    [DataContractAttribute(IsReference=true)]
    [ScaffoldTable(true)]
    [Serializable()]
    public partial class Cat1 : EntityObject
    {
        #region Factory Methods

        /// <summary>
        /// Create a new Cat1 object.
        /// </summary>
        /// <param name="identification">Initial value of the Identification property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Cat1 CreateCat1(global::System.Int32 identification, global::System.String name)
        {
            Cat1 cat1 = new Cat1();
            cat1.Identification = identification;
            cat1.Name = name;

            return cat1;
        }

        #endregion

        #region Primitive Properties

        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Identification
        {
            get
            {
                return _identification;
            }
            set
            {
                if (_identification != value)
                {
                    OnIdentificationChanging(value);
                    ReportPropertyChanging("Identification");
                    _identification = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Identification");
                    OnIdentificationChanged();
                }
            }
        }

        private global::System.Int32 _identification;
        partial void OnIdentificationChanging(global::System.Int32 value);
        partial void OnIdentificationChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    OnNameChanging(value);
                    ReportPropertyChanging("Name");
                    _name = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Name");
                    OnNameChanged();
                }
            }
        }

        private global::System.String _name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    }
}
#pragma warning restore 1591