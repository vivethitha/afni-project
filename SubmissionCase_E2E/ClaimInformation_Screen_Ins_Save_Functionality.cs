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
    ///The ClaimInformation_Screen_Ins_Save_Functionality recording.
    /// </summary>
    [TestModule("95efc8b4-84e6-4631-8b0a-9d365ad53412", ModuleType.Recording, 1)]
    public partial class ClaimInformation_Screen_Ins_Save_Functionality : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static ClaimInformation_Screen_Ins_Save_Functionality instance = new ClaimInformation_Screen_Ins_Save_Functionality();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClaimInformation_Screen_Ins_Save_Functionality()
        {
            ClaimInformation_AccoutType = "";
            ClaimInformation_ClientName = "";
            ClaimInformation_ClaimNumber = "";
            ClaimInformation_ProjectName = "";
            ClaimInformation_ClaimType = "";
            ClaimInformation_Product = "";
            ClaimInformation_StateOfLoss = "";
            ClaimInformation_Street = "";
            ClaimInformation_City = "";
            ClaimInformation_AccidentType = "";
            ClaimInformation_IncidentFacts = "";
            ClaimInformation_IncidentFacts_getValue = "";
            ClaimInformation_AmountofLoss_Save = "";
            ClaimInformation_DeductibleAmount_Save = "";
            ClaimInformation_DateOfLoss_Save = "";
            ClaimInformation_Police_Report_No = "";
            ClaimInformation_AFNI_Liability_Save = "";
            ClaimInformation_Client_Liability_Save = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClaimInformation_Screen_Ins_Save_Functionality Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClaimInformation_AccoutType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccoutType.
        /// </summary>
        [TestVariable("89cb7504-f230-4666-a545-31584176a195")]
        public string ClaimInformation_AccoutType
        {
            get { return _ClaimInformation_AccoutType; }
            set { _ClaimInformation_AccoutType = value; }
        }

        string _ClaimInformation_ClientName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClientName.
        /// </summary>
        [TestVariable("04fab156-2e67-4b01-a455-3ddf1ab84197")]
        public string ClaimInformation_ClientName
        {
            get { return _ClaimInformation_ClientName; }
            set { _ClaimInformation_ClientName = value; }
        }

        string _ClaimInformation_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimNumber.
        /// </summary>
        [TestVariable("599341e0-ef46-4a57-8311-f182320d06e1")]
        public string ClaimInformation_ClaimNumber
        {
            get { return _ClaimInformation_ClaimNumber; }
            set { _ClaimInformation_ClaimNumber = value; }
        }

        string _ClaimInformation_ProjectName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ProjectName.
        /// </summary>
        [TestVariable("1acba35c-6a34-4021-b0d7-dce6d5bfd170")]
        public string ClaimInformation_ProjectName
        {
            get { return _ClaimInformation_ProjectName; }
            set { _ClaimInformation_ProjectName = value; }
        }

        string _ClaimInformation_ClaimType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimType.
        /// </summary>
        [TestVariable("00f561e5-fc7d-4893-87ad-64eb42560173")]
        public string ClaimInformation_ClaimType
        {
            get { return _ClaimInformation_ClaimType; }
            set { _ClaimInformation_ClaimType = value; }
        }

        string _ClaimInformation_Product;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Product.
        /// </summary>
        [TestVariable("2daadbc7-95af-4b8e-abf6-049d9a859349")]
        public string ClaimInformation_Product
        {
            get { return _ClaimInformation_Product; }
            set { _ClaimInformation_Product = value; }
        }

        string _ClaimInformation_StateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_StateOfLoss.
        /// </summary>
        [TestVariable("e3f5685c-e15d-43af-bbfa-845f6871c7dd")]
        public string ClaimInformation_StateOfLoss
        {
            get { return _ClaimInformation_StateOfLoss; }
            set { _ClaimInformation_StateOfLoss = value; }
        }

        string _ClaimInformation_Street;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Street.
        /// </summary>
        [TestVariable("8782c163-50fc-4751-b095-d1f45d67612d")]
        public string ClaimInformation_Street
        {
            get { return _ClaimInformation_Street; }
            set { _ClaimInformation_Street = value; }
        }

        string _ClaimInformation_City;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_City.
        /// </summary>
        [TestVariable("9e4df150-7362-4ec5-8582-1061ce17e308")]
        public string ClaimInformation_City
        {
            get { return _ClaimInformation_City; }
            set { _ClaimInformation_City = value; }
        }

        string _ClaimInformation_AccidentType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccidentType.
        /// </summary>
        [TestVariable("f2f655e6-e9e3-497a-a04e-d2b63a2359a4")]
        public string ClaimInformation_AccidentType
        {
            get { return _ClaimInformation_AccidentType; }
            set { _ClaimInformation_AccidentType = value; }
        }

        string _ClaimInformation_IncidentFacts;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_IncidentFacts.
        /// </summary>
        [TestVariable("b90d2776-f83b-4024-8d1b-5fae2118bdc8")]
        public string ClaimInformation_IncidentFacts
        {
            get { return _ClaimInformation_IncidentFacts; }
            set { _ClaimInformation_IncidentFacts = value; }
        }

        string _ClaimInformation_IncidentFacts_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_IncidentFacts_getValue.
        /// </summary>
        [TestVariable("969fa272-ece9-4bc6-ae9f-b33a275f95a2")]
        public string ClaimInformation_IncidentFacts_getValue
        {
            get { return _ClaimInformation_IncidentFacts_getValue; }
            set { _ClaimInformation_IncidentFacts_getValue = value; }
        }

        string _ClaimInformation_AmountofLoss_Save;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AmountofLoss_Save.
        /// </summary>
        [TestVariable("2b57ab2b-e59a-4c77-a962-73e0d56b1a33")]
        public string ClaimInformation_AmountofLoss_Save
        {
            get { return _ClaimInformation_AmountofLoss_Save; }
            set { _ClaimInformation_AmountofLoss_Save = value; }
        }

        string _ClaimInformation_DeductibleAmount_Save;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_DeductibleAmount_Save.
        /// </summary>
        [TestVariable("32b3b83f-d489-4acb-b1cc-ff3cb1f02ee1")]
        public string ClaimInformation_DeductibleAmount_Save
        {
            get { return _ClaimInformation_DeductibleAmount_Save; }
            set { _ClaimInformation_DeductibleAmount_Save = value; }
        }

        string _ClaimInformation_DateOfLoss_Save;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_DateOfLoss_Save.
        /// </summary>
        [TestVariable("f4272365-f08e-4c7d-9ffa-ca67dc324073")]
        public string ClaimInformation_DateOfLoss_Save
        {
            get { return _ClaimInformation_DateOfLoss_Save; }
            set { _ClaimInformation_DateOfLoss_Save = value; }
        }

        string _ClaimInformation_Police_Report_No;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Police_Report_No.
        /// </summary>
        [TestVariable("22c43faa-9272-45b7-86dd-478c092dbc8b")]
        public string ClaimInformation_Police_Report_No
        {
            get { return _ClaimInformation_Police_Report_No; }
            set { _ClaimInformation_Police_Report_No = value; }
        }

        string _ClaimInformation_AFNI_Liability_Save;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AFNI_Liability_Save.
        /// </summary>
        [TestVariable("5f234f0a-b55f-44a3-a194-a30347843f3e")]
        public string ClaimInformation_AFNI_Liability_Save
        {
            get { return _ClaimInformation_AFNI_Liability_Save; }
            set { _ClaimInformation_AFNI_Liability_Save = value; }
        }

        string _ClaimInformation_Client_Liability_Save;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Client_Liability_Save.
        /// </summary>
        [TestVariable("8a4604e3-a2e9-4b57-8517-7e014c9b2bea")]
        public string ClaimInformation_Client_Liability_Save
        {
            get { return _ClaimInformation_Client_Liability_Save; }
            set { _ClaimInformation_Client_Liability_Save = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_AccountType'", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo.WaitForExists(30000);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_AccoutType) on item 'ApplicationUnderTest.ClaimInformation_AccountType'.", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, "TagValue", ClaimInformation_AccoutType, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$ClaimInformation_ClientName) on item 'ApplicationUnderTest.ClientName_ReadOnly'.", repo.ApplicationUnderTest.ClientName_ReadOnlyInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClientName_ReadOnlyInfo, "InnerText", ClaimInformation_ClientName, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$ClaimInformation_ClaimNumber) on item 'ApplicationUnderTest.ClaimNumber_ReadOnly'.", repo.ApplicationUnderTest.ClaimNumber_ReadOnlyInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimNumber_ReadOnlyInfo, "InnerText", ClaimInformation_ClaimNumber, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_ProjectName) on item 'ApplicationUnderTest.ClaimInformation_ProjectName'.", repo.ApplicationUnderTest.ClaimInformation_ProjectNameInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_ProjectNameInfo, "TagValue", ClaimInformation_ProjectName, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_ClaimType) on item 'ApplicationUnderTest.ClaimInformation_ClaimType'.", repo.ApplicationUnderTest.ClaimInformation_ClaimTypeInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_ClaimTypeInfo, "TagValue", ClaimInformation_ClaimType, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_Product) on item 'ApplicationUnderTest.ClaimInformation_Product'.", repo.ApplicationUnderTest.ClaimInformation_ProductInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_ProductInfo, "TagValue", ClaimInformation_Product, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_DateOfLoss_Save) on item 'ApplicationUnderTest.ClaimInformation_DateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_DateOfLossInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_DateOfLossInfo, "TagValue", ClaimInformation_DateOfLoss_Save, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_DateOfLoss_Save, new RecordItemIndex(10));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_AmountofLoss_Save) on item 'ApplicationUnderTest.ClaimInformation_AmountofLoss'.", repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, "TagValue", ClaimInformation_AmountofLoss_Save, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_AmountofLoss_Save, new RecordItemIndex(12));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_StateOfLoss) on item 'ApplicationUnderTest.ClaimInformation_StateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_StateOfLossInfo, new RecordItemIndex(13));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_StateOfLossInfo, "TagValue", ClaimInformation_StateOfLoss, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_StateOfLoss, new RecordItemIndex(14));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_DeductibleAmount_Save) on item 'ApplicationUnderTest.ClaimInformation_DeductibleAmount'.", repo.ApplicationUnderTest.ClaimInformation_DeductibleAmountInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_DeductibleAmountInfo, "TagValue", ClaimInformation_DeductibleAmount_Save, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_DeductibleAmount_Save, new RecordItemIndex(16));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_Street) on item 'ApplicationUnderTest.ClaimInformation_Street'.", repo.ApplicationUnderTest.ClaimInformation_StreetInfo, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_StreetInfo, "TagValue", ClaimInformation_Street, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_Street, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_City, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$ClaimInformation_City) on item 'ApplicationUnderTest.ClaimInformation_City'.", repo.ApplicationUnderTest.ClaimInformation_CityInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_CityInfo, "TagValue", ClaimInformation_City);
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_Police_Report_No) on item 'ApplicationUnderTest.ClaimInformation_PoliceReportNo'.", repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, "TagValue", ClaimInformation_Police_Report_No, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_Police_Report_No, new RecordItemIndex(22));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_AFNI_Liability_Save) on item 'ApplicationUnderTest.ClaimInformation_PoliceReportNo'.", repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, new RecordItemIndex(23));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, "TagValue", ClaimInformation_AFNI_Liability_Save, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_AFNI_Liability_Save, new RecordItemIndex(24));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_Client_Liability_Save) on item 'ApplicationUnderTest.ClaimInformation_PoliceReportNo'.", repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, new RecordItemIndex(25));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_PoliceReportNoInfo, "TagValue", ClaimInformation_Client_Liability_Save, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_Client_Liability_Save, new RecordItemIndex(26));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_AccidentType) on item 'ApplicationUnderTest.ClaimInformation_Accident_Type'.", repo.ApplicationUnderTest.ClaimInformation_Accident_TypeInfo, new RecordItemIndex(27));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_Accident_TypeInfo, "TagValue", ClaimInformation_AccidentType, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_AccidentType, new RecordItemIndex(28));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Checked='True') on item 'ApplicationUnderTest.ClaimInformation_TotalLoss'.", repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, new RecordItemIndex(29));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, "Checked", "True", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Value='true') on item 'ApplicationUnderTest.ClaimInformation_TotalLoss'.", repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, new RecordItemIndex(30));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, "Value", "true", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(30)); }
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_IncidentFacts_getValue, new RecordItemIndex(31));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (TagValue=$ClaimInformation_IncidentFacts) on item 'ApplicationUnderTest.ClaimInformation_IncidentFacts'.", repo.ApplicationUnderTest.ClaimInformation_IncidentFactsInfo, new RecordItemIndex(32));
                Validate.AttributeEqual(repo.ApplicationUnderTest.ClaimInformation_IncidentFactsInfo, "TagValue", ClaimInformation_IncidentFacts, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(32)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 41;11.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(33));
            repo.ApplicationUnderTest.SubmitButton1.Click("41;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
