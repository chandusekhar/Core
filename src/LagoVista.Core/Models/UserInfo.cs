﻿using LagoVista.Core.Attributes;
using LagoVista.Core.Resources;
using LagoVista.Core.Interfaces;
using LagoVista.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LagoVista.Core.Models
{
    /* The AppUser is used for managing identity for the system, we want something with basic user information that doesn't
     * do anything with security or identity...this is that object */

    [EntityDescription(AuthDomain.AuthenticationDomain, AuthenticationResources.Names.UserInfo_Title, AuthenticationResources.Names.UserInfo_Help, AuthenticationResources.Names.UserInfo_Description, EntityDescriptionAttribute.EntityTypes.Dto, typeof(AuthenticationResources))]
    public class UserInfo : IUserInfo
    {
        public String Id { get; set; }

        public String Key { get; set; }


        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsSystemAdmin, ResourceType: typeof(AuthenticationResources))]
        public String Name { get; set; }
   
        [FormField(LabelResource: Resources.AuthenticationResources.Names.Common_CreationDate, FieldType: FieldTypes.JsonDateTime, ResourceType: typeof(AuthenticationResources), IsRequired: true, IsUserEditable: false)]
        public String CreationDate { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.Common_CreatedBy, ResourceType: typeof(AuthenticationResources), IsRequired: true, IsUserEditable: false)]
        public EntityHeader CreatedBy { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.Common_LastUpdatedDate, FieldType: FieldTypes.JsonDateTime, ResourceType: typeof(AuthenticationResources), IsRequired: true, IsUserEditable: false)]
        public String LastUpdatedDate { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.Common_LastUpdatedBy, ResourceType: typeof(AuthenticationResources), IsRequired: true, IsUserEditable: false)]
        public EntityHeader LastUpdatedBy { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_FirstName, IsRequired: true, ResourceType: typeof(Resources.AuthenticationResources))]
        public string FirstName { get; set; }
        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_LastName, IsRequired: true, ResourceType: typeof(Resources.AuthenticationResources))]
        public string LastName { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_IsSystemAdmin, HelpResource: Resources.AuthenticationResources.Names.UserInfo_IsSystemAdmin_Help, FieldType:FieldTypes.CheckBox, ResourceType: typeof(Resources.AuthenticationResources))]
        public bool IsSystemAdmin { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_IsOrgAdmin, HelpResource: Resources.AuthenticationResources.Names.UserInfo_IsOrgAdmin_Help, FieldType: FieldTypes.CheckBox, ResourceType: typeof(Resources.AuthenticationResources))]
        public bool IsOrgAdmin { get; set; }

        [FormField(LabelResource: AuthenticationResources.Names.UserInfo_IsAppBuilder, FieldType: FieldTypes.CheckBox, ResourceType: typeof(AuthenticationResources))]
        public bool IsAppBuilder { get; set; }

        [FormField(LabelResource: AuthenticationResources.Names.UserInfo_IsUserDevice, FieldType: FieldTypes.CheckBox, ResourceType: typeof(AuthenticationResources))]
        public bool IsUserDevice { get; set; }

        [FormField(LabelResource: AuthenticationResources.Names.UserInfo_IsRuntimeUser, FieldType: FieldTypes.CheckBox, ResourceType: typeof(AuthenticationResources))]
        public bool IsRuntimeUser { get; set; }

        [FormField(LabelResource: AuthenticationResources.Names.UserInfo_IsAccountDisabled, FieldType: FieldTypes.CheckBox, ResourceType: typeof(AuthenticationResources))]
        public bool IsAccountDisabled { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_IsPreviewUser, HelpResource: Resources.AuthenticationResources.Names.UserInfo_IsPreviewUser, IsRequired: true, FieldType: FieldTypes.CheckBox, ResourceType: typeof(Resources.AuthenticationResources))]
        public bool IsPreviewUser { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_PhoneNumber, FieldType: FieldTypes.Phone, ResourceType: typeof(Resources.AuthenticationResources))]
        public string PhoneNumber { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_IsPhoneConfirmed, IsUserEditable: false, FieldType: FieldTypes.CheckBox, ResourceType: typeof(Resources.AuthenticationResources))]
        public bool PhoneNumberConfirmed { get; set; }

        public EntityHeader CurrentOrganization { get; set; }

        public EntityHeader PrimaryDevice { get; set; }
        public EntityHeader DeviceRepo { get; set; }
        public EntityHeader DeviceConfiguration { get; set; }


        public ImageDetails ProfileImageUrl { get; set; }

        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_Email, IsRequired: true, FieldType: FieldTypes.Email, ResourceType: typeof(Resources.AuthenticationResources))]
        public string Email { get; set; }
        [FormField(LabelResource: Resources.AuthenticationResources.Names.UserInfo_IsEmailConfirmed, IsUserEditable: false, FieldType: FieldTypes.CheckBox, ResourceType: typeof(Resources.AuthenticationResources))]
        public bool EmailConfirmed { get; set; }

        public EntityHeader ToEntityHeader()
        {
            return new EntityHeader()
            {
                Id = Id,
                Text = $"{FirstName} {LastName}"
            };
        }

        public UserInfoSummary CreateSummary()
        {
            return new UserInfoSummary()
            {
                Id = Id,
                Key = Id,
                CreationDate = CreationDate,
                Name = $"{FirstName} {LastName}",
                Email = Email,
                IsSystemAdmin = IsSystemAdmin,
                IsAppBuilder = IsAppBuilder,
                IsUserDevice = IsUserDevice,
                IsOrgAdmin = IsOrgAdmin,
                IsAccountDisabled = IsAccountDisabled,
                IsRuntimeUser = IsRuntimeUser,
                ProfileImageUrl = ProfileImageUrl,
                EmailConfirmed = EmailConfirmed,
                PhoneNumberConfirmed = PhoneNumberConfirmed
            };
        }
    }


    public class UserInfoSummary
    {
        [ListColumn(Visible: false)]
        public String Id { get; set; }
        [ListColumn(Visible: false)]
        public String Key { get; set; }

        
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsSystemAdmin, ResourceType: typeof(AuthenticationResources))]
        public bool IsSystemAdmin { get; set; }

        [ListColumn(HeaderResource:AuthenticationResources.Names.UserInfo_DateCreated, ResourceType: typeof(AuthenticationResources))]
        public string CreationDate { get; set; }

        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsOrgAdmin, ResourceType: typeof(AuthenticationResources))]
        public bool IsOrgAdmin { get; set; }
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsAppBuilder, ResourceType: typeof(AuthenticationResources))]
        public bool IsAppBuilder { get; set; }
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsUserDevice, ResourceType: typeof(AuthenticationResources))]
        public bool IsUserDevice { get; set; }
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsRuntimeUser, ResourceType: typeof(AuthenticationResources))]
        public bool IsRuntimeUser { get; set; }

        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsAccountDisabled, ResourceType: typeof(AuthenticationResources))]
        public bool IsAccountDisabled { get; set; }

        [ListColumn(HeaderResource: AuthenticationResources.Names.Common_Name, ResourceType: typeof(AuthenticationResources))]
        public String Name { get; set; }

        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_Email, ResourceType: typeof(AuthenticationResources))]
        public String Email { get; set; }

        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_PhoneNumber, ResourceType: typeof(AuthenticationResources))]
        public String PhoneNumber { get; set; }


        [ListColumn(Visible: false)]
        public ImageDetails ProfileImageUrl { get; set; }
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsEmailConfirmed, ResourceType: typeof(AuthenticationResources))]
        public bool EmailConfirmed { get; set; }
        [ListColumn(HeaderResource: AuthenticationResources.Names.UserInfo_IsPhoneConfirmed, ResourceType: typeof(AuthenticationResources))]
        public bool PhoneNumberConfirmed { get; set; }
    }
}