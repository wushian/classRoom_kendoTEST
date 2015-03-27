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
    [EdmEntityTypeAttribute(NamespaceName="classRoomWebSite.Data", Name="SystemUser")]
    [DataContractAttribute(IsReference=true)]
    [ScaffoldTable(true)]
    [Serializable()]
    public partial class SystemUser : EntityObject
    {
        #region Factory Methods

        /// <summary>
        /// Create a new SystemUser object.
        /// </summary>
        /// <param name="identification">Initial value of the Identification property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="account">Initial value of the Account property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="salt">Initial value of the Salt property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="createDate">Initial value of the CreateDate property.</param>
        /// <param name="updateDate">Initial value of the UpdateDate property.</param>
        public static SystemUser CreateSystemUser(global::System.Guid identification, global::System.String name, global::System.String account, global::System.String password, global::System.String salt, global::System.String email, global::System.DateTime createDate, global::System.DateTime updateDate)
        {
            SystemUser systemUser = new SystemUser();
            systemUser.Identification = identification;
            systemUser.Name = name;
            systemUser.Account = account;
            systemUser.Password = password;
            systemUser.Salt = salt;
            systemUser.Email = email;
            systemUser.CreateDate = createDate;
            systemUser.UpdateDate = updateDate;

            return systemUser;
        }

        #endregion

        #region Primitive Properties

        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Identification
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

        private global::System.Guid _identification;
        partial void OnIdentificationChanging(global::System.Guid value);
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

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Account
        {
            get
            {
                return _account;
            }
            set
            {
                if (_account != value)
                {
                    OnAccountChanging(value);
                    ReportPropertyChanging("Account");
                    _account = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Account");
                    OnAccountChanged();
                }
            }
        }

        private global::System.String _account;
        partial void OnAccountChanging(global::System.String value);
        partial void OnAccountChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password != value)
                {
                    OnPasswordChanging(value);
                    ReportPropertyChanging("Password");
                    _password = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Password");
                    OnPasswordChanged();
                }
            }
        }

        private global::System.String _password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Salt
        {
            get
            {
                return _salt;
            }
            set
            {
                if (_salt != value)
                {
                    OnSaltChanging(value);
                    ReportPropertyChanging("Salt");
                    _salt = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Salt");
                    OnSaltChanged();
                }
            }
        }

        private global::System.String _salt;
        partial void OnSaltChanging(global::System.String value);
        partial void OnSaltChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    OnEmailChanging(value);
                    ReportPropertyChanging("Email");
                    _email = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Email");
                    OnEmailChanged();
                }
            }
        }

        private global::System.String _email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                if (_createDate != value)
                {
                    OnCreateDateChanging(value);
                    ReportPropertyChanging("CreateDate");
                    _createDate = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CreateDate");
                    OnCreateDateChanged();
                }
            }
        }

        private global::System.DateTime _createDate;
        partial void OnCreateDateChanging(global::System.DateTime value);
        partial void OnCreateDateChanged();

        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime UpdateDate
        {
            get
            {
                return _updateDate;
            }
            set
            {
                if (_updateDate != value)
                {
                    OnUpdateDateChanging(value);
                    ReportPropertyChanging("UpdateDate");
                    _updateDate = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UpdateDate");
                    OnUpdateDateChanged();
                }
            }
        }

        private global::System.DateTime _updateDate;
        partial void OnUpdateDateChanging(global::System.DateTime value);
        partial void OnUpdateDateChanged();

        #endregion
    }
}
#pragma warning restore 1591