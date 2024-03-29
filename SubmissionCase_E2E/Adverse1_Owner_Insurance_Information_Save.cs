﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Adverse1_Owner_Insurance_Information_Save recording.
    /// </summary>
    [TestModule("c669ecee-431d-4ba5-86cc-21eca774c705", ModuleType.Recording, 1)]
    public partial class Adverse1_Owner_Insurance_Information_Save : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Owner_Insurance_Information_Save instance = new Adverse1_Owner_Insurance_Information_Save();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Owner_Insurance_Information_Save()
        {
            AO_LI_PolicyNumber = "";
            AO_LI_ClaimNumber = "";
            AO_LI_ContactName = "";
            AO_LI_State = "";
            AO_LI_Address1 = "";
            AO_LI_City = "";
            AO_LI_Zip = "";
            AO_LI_PhoneUseType_getValue = "";
            AO_LI_PhoneType_getValue = "";
            AO_LI_PhoneSource_getValue = "";
            AO_LI_PhoneNumber_getValue = "";
            AO_LI_Email_getValue = "";
            AO_LI_Address2 = "";
            AO_LI_EmailUseType_getValue = "";
            AO_LI_EmailSource_getValue = "";
            AO_LI_EmailId_getValue = "";
            AO_LI_Company_Name = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Owner_Insurance_Information_Save Instance
        {
            get { return instance; }
        }

#region Variables

        string _AO_LI_PolicyNumber;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_PolicyNumber.
        /// </summary>
        [TestVariable("be5a295b-c62c-498c-a579-75343c98f275")]
        public string AO_LI_PolicyNumber
        {
            get { return _AO_LI_PolicyNumber; }
            set { _AO_LI_PolicyNumber = value; }
        }

        string _AO_LI_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_ClaimNumber.
        /// </summary>
        [TestVariable("40270489-7104-4deb-9291-e0497d7424c4")]
        public string AO_LI_ClaimNumber
        {
            get { return _AO_LI_ClaimNumber; }
            set { _AO_LI_ClaimNumber = value; }
        }

        string _AO_LI_ContactName;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_ContactName.
        /// </summary>
        [TestVariable("742e79e3-7a31-43ea-b4d2-b256aab7c582")]
        public string AO_LI_ContactName
        {
            get { return _AO_LI_ContactName; }
            set { _AO_LI_ContactName = value; }
        }

        string _AO_LI_State;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_State.
        /// </summary>
        [TestVariable("fd8e178c-0d63-4000-87ec-5aff9b32d537")]
        public string AO_LI_State
        {
            get { return _AO_LI_State; }
            set { _AO_LI_State = value; }
        }

        string _AO_LI_Address1;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_Address1.
        /// </summary>
        [TestVariable("c5429cb8-9634-4d5b-9e45-5dc08e0a257b")]
        public string AO_LI_Address1
        {
            get { return _AO_LI_Address1; }
            set { _AO_LI_Address1 = value; }
        }

        string _AO_LI_City;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_City.
        /// </summary>
        [TestVariable("1289779a-3b64-43d6-a981-ae2d2951842f")]
        public string AO_LI_City
        {
            get { return _AO_LI_City; }
            set { _AO_LI_City = value; }
        }

        string _AO_LI_Zip;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_Zip.
        /// </summary>
        [TestVariable("504fccf4-320c-4596-ba86-fe4baea6da02")]
        public string AO_LI_Zip
        {
            get { return _AO_LI_Zip; }
            set { _AO_LI_Zip = value; }
        }

        string _AO_LI_PhoneUseType_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_PhoneUseType_getValue.
        /// </summary>
        [TestVariable("d791accf-0ab6-4401-ad91-0496004f30ef")]
        public string AO_LI_PhoneUseType_getValue
        {
            get { return _AO_LI_PhoneUseType_getValue; }
            set { _AO_LI_PhoneUseType_getValue = value; }
        }

        string _AO_LI_PhoneType_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_PhoneType_getValue.
        /// </summary>
        [TestVariable("0fbce098-1f0d-4ff5-9f6c-17019bd5efc9")]
        public string AO_LI_PhoneType_getValue
        {
            get { return _AO_LI_PhoneType_getValue; }
            set { _AO_LI_PhoneType_getValue = value; }
        }

        string _AO_LI_PhoneSource_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_PhoneSource_getValue.
        /// </summary>
        [TestVariable("13e75fb8-afc2-4c7d-86aa-242b5769471d")]
        public string AO_LI_PhoneSource_getValue
        {
            get { return _AO_LI_PhoneSource_getValue; }
            set { _AO_LI_PhoneSource_getValue = value; }
        }

        string _AO_LI_PhoneNumber_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_PhoneNumber_getValue.
        /// </summary>
        [TestVariable("57c02798-54ea-4298-a580-e9393ea6d762")]
        public string AO_LI_PhoneNumber_getValue
        {
            get { return _AO_LI_PhoneNumber_getValue; }
            set { _AO_LI_PhoneNumber_getValue = value; }
        }

        string _AO_LI_Email_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_Email_getValue.
        /// </summary>
        [TestVariable("fd2a0325-55e4-43a4-ba59-72cf05572d21")]
        public string AO_LI_Email_getValue
        {
            get { return _AO_LI_Email_getValue; }
            set { _AO_LI_Email_getValue = value; }
        }

        string _AO_LI_Address2;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_Address2.
        /// </summary>
        [TestVariable("8ea4c9dd-cbb9-4e75-a561-65f482c09777")]
        public string AO_LI_Address2
        {
            get { return _AO_LI_Address2; }
            set { _AO_LI_Address2 = value; }
        }

        string _AO_LI_EmailUseType_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_EmailUseType_getValue.
        /// </summary>
        [TestVariable("50ac2204-511d-44b3-88b8-940b4a50653c")]
        public string AO_LI_EmailUseType_getValue
        {
            get { return _AO_LI_EmailUseType_getValue; }
            set { _AO_LI_EmailUseType_getValue = value; }
        }

        string _AO_LI_EmailSource_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_EmailSource_getValue.
        /// </summary>
        [TestVariable("d88c5093-8570-4f13-8197-c9c6228eaa87")]
        public string AO_LI_EmailSource_getValue
        {
            get { return _AO_LI_EmailSource_getValue; }
            set { _AO_LI_EmailSource_getValue = value; }
        }

        string _AO_LI_EmailId_getValue;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_EmailId_getValue.
        /// </summary>
        [TestVariable("6007e56b-5a2d-491e-b9e9-1fc0d53c3f83")]
        public string AO_LI_EmailId_getValue
        {
            get { return _AO_LI_EmailId_getValue; }
            set { _AO_LI_EmailId_getValue = value; }
        }

        string _AO_LI_Company_Name;

        /// <summary>
        /// Gets or sets the value of variable AO_LI_Company_Name.
        /// </summary>
        [TestVariable("5c8eb7d7-6133-4c07-8074-4b7f57988867")]
        public string AO_LI_Company_Name
        {
            get { return _AO_LI_Company_Name; }
            set { _AO_LI_Company_Name = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Save_Button' at 6;8.", repo.ApplicationUnderTest.Save_ButtonInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Save_Button.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_CompanyName' and assigning its value to variable 'AO_LI_Company_Name'.", repo.ApplicationUnderTest.AO_LI_CompanyNameInfo, new RecordItemIndex(2));
            AO_LI_Company_Name = repo.ApplicationUnderTest.AO_LI_CompanyName.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_Company_Name) on item 'ApplicationUnderTest.AO_LI_CompanyName'.", repo.ApplicationUnderTest.AO_LI_CompanyNameInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_CompanyNameInfo, "TagValue", AO_LI_Company_Name);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_Company_Name, new RecordItemIndex(4));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'ApplicationUnderTest.OAT_IL_RentalCompany'.", repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.OAT_IL_RentalCompanyInfo, "Checked", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_PolicyNumber' and assigning its value to variable 'AO_LI_PolicyNumber'.", repo.ApplicationUnderTest.AO_LI_PolicyNumberInfo, new RecordItemIndex(6));
            //AO_LI_PolicyNumber = repo.ApplicationUnderTest.AO_LI_PolicyNumber.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_PolicyNumber) on item 'ApplicationUnderTest.AO_LI_PolicyNumber'.", repo.ApplicationUnderTest.AO_LI_PolicyNumberInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_PolicyNumberInfo, "TagValue", AO_LI_PolicyNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_PolicyNumber, new RecordItemIndex(8));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_ClaimNumber' and assigning its value to variable 'AO_LI_ClaimNumber'.", repo.ApplicationUnderTest.AO_LI_ClaimNumberInfo, new RecordItemIndex(9));
            //AO_LI_ClaimNumber = repo.ApplicationUnderTest.AO_LI_ClaimNumber.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_ClaimNumber) on item 'ApplicationUnderTest.AO_LI_ClaimNumber'.", repo.ApplicationUnderTest.AO_LI_ClaimNumberInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_ClaimNumberInfo, "TagValue", AO_LI_ClaimNumber);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_ClaimNumber, new RecordItemIndex(11));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_ContactName' and assigning its value to variable 'AO_LI_ContactName'.", repo.ApplicationUnderTest.AO_LI_ContactNameInfo, new RecordItemIndex(12));
            //AO_LI_ContactName = repo.ApplicationUnderTest.AO_LI_ContactName.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_ContactName) on item 'ApplicationUnderTest.AO_LI_ContactName'.", repo.ApplicationUnderTest.AO_LI_ContactNameInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_ContactNameInfo, "TagValue", AO_LI_ContactName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_ContactName, new RecordItemIndex(14));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_State' and assigning its value to variable 'AO_LI_State'.", repo.ApplicationUnderTest.AO_LI_StateInfo, new RecordItemIndex(15));
            //AO_LI_State = repo.ApplicationUnderTest.AO_LI_State.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_State) on item 'ApplicationUnderTest.AO_LI_State'.", repo.ApplicationUnderTest.AO_LI_StateInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_StateInfo, "TagValue", AO_LI_State);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_State, new RecordItemIndex(17));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_Address1' and assigning its value to variable 'AO_LI_Address1'.", repo.ApplicationUnderTest.AO_LI_Address1Info, new RecordItemIndex(18));
            //AO_LI_Address1 = repo.ApplicationUnderTest.AO_LI_Address1.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_Address1) on item 'ApplicationUnderTest.AO_LI_Address1'.", repo.ApplicationUnderTest.AO_LI_Address1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_Address1Info, "TagValue", AO_LI_Address1);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_Address1, new RecordItemIndex(20));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_Address2' and assigning its value to variable 'AO_LI_Address2'.", repo.ApplicationUnderTest.AO_LI_Address2Info, new RecordItemIndex(21));
            //AO_LI_Address2 = repo.ApplicationUnderTest.AO_LI_Address2.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_Address2) on item 'ApplicationUnderTest.AO_LI_Address2'.", repo.ApplicationUnderTest.AO_LI_Address2Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_Address2Info, "TagValue", AO_LI_Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_Address2, new RecordItemIndex(23));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_City' and assigning its value to variable 'AO_LI_City'.", repo.ApplicationUnderTest.AO_LI_CityInfo, new RecordItemIndex(24));
            //AO_LI_City = repo.ApplicationUnderTest.AO_LI_City.Element.GetAttributeValueText("TagValue");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_City) on item 'ApplicationUnderTest.AO_LI_City'.", repo.ApplicationUnderTest.AO_LI_CityInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_CityInfo, "TagValue", AO_LI_City);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_City, new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_Zip' and assigning its value to variable 'AO_LI_Zip'.", repo.ApplicationUnderTest.AO_LI_ZipInfo, new RecordItemIndex(27));
            AO_LI_Zip = repo.ApplicationUnderTest.AO_LI_Zip.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_Zip) on item 'ApplicationUnderTest.AO_LI_Zip'.", repo.ApplicationUnderTest.AO_LI_ZipInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_ZipInfo, "TagValue", AO_LI_Zip);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_Zip, new RecordItemIndex(29));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AO_LI_EmailId' at Center.", repo.ApplicationUnderTest.AO_LI_EmailIdInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.AO_LI_EmailId.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_PhoneUseType' and assigning its value to variable 'AO_LI_PhoneUseType_getValue'.", repo.ApplicationUnderTest.AO_LI_PhoneUseTypeInfo, new RecordItemIndex(32));
            AO_LI_PhoneUseType_getValue = repo.ApplicationUnderTest.AO_LI_PhoneUseType.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_PhoneUseType_getValue, new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_PhoneUseType_getValue) on item 'ApplicationUnderTest.AO_LI_PhoneUseType'.", repo.ApplicationUnderTest.AO_LI_PhoneUseTypeInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_PhoneUseTypeInfo, "TagValue", AO_LI_PhoneUseType_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_PhoneType' and assigning its value to variable 'AO_LI_PhoneType_getValue'.", repo.ApplicationUnderTest.AO_LI_PhoneTypeInfo, new RecordItemIndex(35));
            AO_LI_PhoneType_getValue = repo.ApplicationUnderTest.AO_LI_PhoneType.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_PhoneType_getValue, new RecordItemIndex(36));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_PhoneType_getValue) on item 'ApplicationUnderTest.AO_LI_PhoneType'.", repo.ApplicationUnderTest.AO_LI_PhoneTypeInfo, new RecordItemIndex(37));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_PhoneTypeInfo, "TagValue", AO_LI_PhoneType_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_PhoneSource' and assigning its value to variable 'AO_LI_PhoneSource_getValue'.", repo.ApplicationUnderTest.AO_LI_PhoneSourceInfo, new RecordItemIndex(38));
            AO_LI_PhoneSource_getValue = repo.ApplicationUnderTest.AO_LI_PhoneSource.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_PhoneSource_getValue, new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_PhoneSource_getValue) on item 'ApplicationUnderTest.AO_LI_PhoneSource'.", repo.ApplicationUnderTest.AO_LI_PhoneSourceInfo, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_PhoneSourceInfo, "TagValue", AO_LI_PhoneSource_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_PhoneNumber' and assigning its value to variable 'AO_LI_PhoneNumber_getValue'.", repo.ApplicationUnderTest.AO_LI_PhoneNumberInfo, new RecordItemIndex(41));
            AO_LI_PhoneNumber_getValue = repo.ApplicationUnderTest.AO_LI_PhoneNumber.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_PhoneNumber_getValue, new RecordItemIndex(42));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_PhoneNumber_getValue) on item 'ApplicationUnderTest.AO_LI_PhoneNumber'.", repo.ApplicationUnderTest.AO_LI_PhoneNumberInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_PhoneNumberInfo, "TagValue", AO_LI_PhoneNumber_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_EmailUseType' and assigning its value to variable 'AO_LI_EmailUseType_getValue'.", repo.ApplicationUnderTest.AO_LI_EmailUseTypeInfo, new RecordItemIndex(44));
            AO_LI_EmailUseType_getValue = repo.ApplicationUnderTest.AO_LI_EmailUseType.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_EmailUseType_getValue, new RecordItemIndex(45));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_EmailUseType_getValue) on item 'ApplicationUnderTest.AO_LI_EmailUseType'.", repo.ApplicationUnderTest.AO_LI_EmailUseTypeInfo, new RecordItemIndex(46));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_EmailUseTypeInfo, "TagValue", AO_LI_EmailUseType_getValue);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_EmailSource' and assigning its value to variable 'AO_LI_EmailSource_getValue'.", repo.ApplicationUnderTest.AO_LI_EmailSourceInfo, new RecordItemIndex(47));
            AO_LI_EmailSource_getValue = repo.ApplicationUnderTest.AO_LI_EmailSource.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_EmailSource_getValue, new RecordItemIndex(48));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_EmailSource_getValue) on item 'ApplicationUnderTest.AO_LI_EmailSource'.", repo.ApplicationUnderTest.AO_LI_EmailSourceInfo, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_EmailSourceInfo, "TagValue", AO_LI_EmailSource_getValue);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'TagValue' from item 'ApplicationUnderTest.AO_LI_EmailId' and assigning its value to variable 'AO_LI_EmailId_getValue'.", repo.ApplicationUnderTest.AO_LI_EmailIdInfo, new RecordItemIndex(50));
            AO_LI_EmailId_getValue = repo.ApplicationUnderTest.AO_LI_EmailId.Element.GetAttributeValueText("TagValue");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AO_LI_EmailId_getValue, new RecordItemIndex(51));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$AO_LI_EmailId_getValue) on item 'ApplicationUnderTest.AO_LI_EmailId'.", repo.ApplicationUnderTest.AO_LI_EmailIdInfo, new RecordItemIndex(52));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AO_LI_EmailIdInfo, "TagValue", AO_LI_EmailId_getValue);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(53));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 46;15.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(54));
            repo.ApplicationUnderTest.SubmitButton1.Click("46;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
