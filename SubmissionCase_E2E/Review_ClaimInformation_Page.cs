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
    ///The Review_ClaimInformation_Page recording.
    /// </summary>
    [TestModule("05d627ea-34b3-4488-a2aa-525950474579", ModuleType.Recording, 1)]
    public partial class Review_ClaimInformation_Page : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Review_ClaimInformation_Page instance = new Review_ClaimInformation_Page();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Review_ClaimInformation_Page()
        {
            ClaimInformation_AccoutType = "";
            ClaimInformation_ClientName = "";
            ClaimInformation_ClaimNumber = "";
            ClaimInformation_ProjectName = "";
            ClaimInformation_ClaimType = "";
            ClaimInformation_Product = "";
            claimInformation_DataOfLoss_getValue = "";
            ClaimInformation_AmountofLoss_getValue = "";
            ClaimInformation_StateOfLoss_getValue = "";
            ClaimInformation_DeductibleAmount_getValue = "";
            ClaimInformation_PoliceReportNo_getValue = "";
            ClaimInformation_Street_getValue = "";
            ClaimInformation_City_getValue = "";
            ClaimInformation_AccidentType_getValue = "";
            ClaimInformation_IncidentFacts_getValue = "";
            ClaimInformation_IncidentFacts = "";
            Edit_ClaimInformation_Street = "EI_Street";
            Edit_claimInformation_PoliceReportNo = "EI_Police_Report_No";
            Edit_ClaimInformation_DataOfLoss = "6/12/2019";
            Edit_ClaimInformation_AmountOfLoss = "5423";
            Edit_Claim_Information_StateOfLoss = "AR";
            Edit_Claim_Information_DeductibleAmount = "600";
            Edit_ClaimInformation_City = "EI_City";
            Edit_ClaimInfroamtion_AccidentType = "Merging";
            Edit_ClaimInformation_IncidentFacts = "EI_Test";
            ClaimInformation_Afni_Liability = "";
            Edit_Claim_Afni_Liability = "25";
            ClaimInformation_Client_Liability = "";
            Edit_ClaimInfomation_Client_Liability = "50";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Review_ClaimInformation_Page Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClaimInformation_AccoutType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccoutType.
        /// </summary>
        [TestVariable("a49e3433-5323-4b8c-b8db-aa9809456b53")]
        public string ClaimInformation_AccoutType
        {
            get { return _ClaimInformation_AccoutType; }
            set { _ClaimInformation_AccoutType = value; }
        }

        string _ClaimInformation_ClientName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClientName.
        /// </summary>
        [TestVariable("b01ae45d-784b-42d5-ace9-2b5c05930c0c")]
        public string ClaimInformation_ClientName
        {
            get { return _ClaimInformation_ClientName; }
            set { _ClaimInformation_ClientName = value; }
        }

        string _ClaimInformation_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimNumber.
        /// </summary>
        [TestVariable("cf2bfa99-1122-4c3c-8cd8-05c746b320a9")]
        public string ClaimInformation_ClaimNumber
        {
            get { return _ClaimInformation_ClaimNumber; }
            set { _ClaimInformation_ClaimNumber = value; }
        }

        string _ClaimInformation_ProjectName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ProjectName.
        /// </summary>
        [TestVariable("068fd601-1609-4624-8141-3c4286c8e5f9")]
        public string ClaimInformation_ProjectName
        {
            get { return _ClaimInformation_ProjectName; }
            set { _ClaimInformation_ProjectName = value; }
        }

        string _ClaimInformation_ClaimType;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimType.
        /// </summary>
        [TestVariable("f031a4eb-334a-475e-a096-4b63962c5259")]
        public string ClaimInformation_ClaimType
        {
            get { return _ClaimInformation_ClaimType; }
            set { _ClaimInformation_ClaimType = value; }
        }

        string _ClaimInformation_Product;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Product.
        /// </summary>
        [TestVariable("cfd1a0d9-8e4d-4e5d-a423-28fea65a27ce")]
        public string ClaimInformation_Product
        {
            get { return _ClaimInformation_Product; }
            set { _ClaimInformation_Product = value; }
        }

        string _claimInformation_DataOfLoss_getValue;

        /// <summary>
        /// Gets or sets the value of variable claimInformation_DataOfLoss_getValue.
        /// </summary>
        [TestVariable("537033a5-74bf-4e22-9e40-28b601f05ffa")]
        public string claimInformation_DataOfLoss_getValue
        {
            get { return _claimInformation_DataOfLoss_getValue; }
            set { _claimInformation_DataOfLoss_getValue = value; }
        }

        string _ClaimInformation_AmountofLoss_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AmountofLoss_getValue.
        /// </summary>
        [TestVariable("457d04c4-af2a-48b6-a063-396745ec357f")]
        public string ClaimInformation_AmountofLoss_getValue
        {
            get { return _ClaimInformation_AmountofLoss_getValue; }
            set { _ClaimInformation_AmountofLoss_getValue = value; }
        }

        string _ClaimInformation_StateOfLoss_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_StateOfLoss_getValue.
        /// </summary>
        [TestVariable("8e13c4b4-d483-43ef-8e9c-e38824260b84")]
        public string ClaimInformation_StateOfLoss_getValue
        {
            get { return _ClaimInformation_StateOfLoss_getValue; }
            set { _ClaimInformation_StateOfLoss_getValue = value; }
        }

        string _ClaimInformation_DeductibleAmount_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_DeductibleAmount_getValue.
        /// </summary>
        [TestVariable("46a395c1-1244-422b-a214-9bd3e433bd7e")]
        public string ClaimInformation_DeductibleAmount_getValue
        {
            get { return _ClaimInformation_DeductibleAmount_getValue; }
            set { _ClaimInformation_DeductibleAmount_getValue = value; }
        }

        string _ClaimInformation_PoliceReportNo_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_PoliceReportNo_getValue.
        /// </summary>
        [TestVariable("0812be8b-99bc-425e-802f-1ce65c728373")]
        public string ClaimInformation_PoliceReportNo_getValue
        {
            get { return _ClaimInformation_PoliceReportNo_getValue; }
            set { _ClaimInformation_PoliceReportNo_getValue = value; }
        }

        string _ClaimInformation_Street_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Street_getValue.
        /// </summary>
        [TestVariable("c087032a-0e48-426f-809a-88fb2c373999")]
        public string ClaimInformation_Street_getValue
        {
            get { return _ClaimInformation_Street_getValue; }
            set { _ClaimInformation_Street_getValue = value; }
        }

        string _ClaimInformation_City_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_City_getValue.
        /// </summary>
        [TestVariable("3afedb59-6e9c-44f5-bab2-c7b585668722")]
        public string ClaimInformation_City_getValue
        {
            get { return _ClaimInformation_City_getValue; }
            set { _ClaimInformation_City_getValue = value; }
        }

        string _ClaimInformation_AccidentType_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_AccidentType_getValue.
        /// </summary>
        [TestVariable("0c2e637f-aed8-455e-94fd-f80e3baca2b4")]
        public string ClaimInformation_AccidentType_getValue
        {
            get { return _ClaimInformation_AccidentType_getValue; }
            set { _ClaimInformation_AccidentType_getValue = value; }
        }

        string _ClaimInformation_IncidentFacts_getValue;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_IncidentFacts_getValue.
        /// </summary>
        [TestVariable("2fce53b8-968c-452e-bd9f-f8616272e2dd")]
        public string ClaimInformation_IncidentFacts_getValue
        {
            get { return _ClaimInformation_IncidentFacts_getValue; }
            set { _ClaimInformation_IncidentFacts_getValue = value; }
        }

        string _ClaimInformation_IncidentFacts;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_IncidentFacts.
        /// </summary>
        [TestVariable("d4fa9607-246b-4c4b-8c21-5440e67ba672")]
        public string ClaimInformation_IncidentFacts
        {
            get { return _ClaimInformation_IncidentFacts; }
            set { _ClaimInformation_IncidentFacts = value; }
        }

        string _Edit_ClaimInformation_Street;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInformation_Street.
        /// </summary>
        [TestVariable("bf29edc6-3aa8-4422-aec1-77182379752b")]
        public string Edit_ClaimInformation_Street
        {
            get { return _Edit_ClaimInformation_Street; }
            set { _Edit_ClaimInformation_Street = value; }
        }

        string _Edit_claimInformation_PoliceReportNo;

        /// <summary>
        /// Gets or sets the value of variable Edit_claimInformation_PoliceReportNo.
        /// </summary>
        [TestVariable("9e2786e6-8ddd-4720-a269-e25dfae42997")]
        public string Edit_claimInformation_PoliceReportNo
        {
            get { return _Edit_claimInformation_PoliceReportNo; }
            set { _Edit_claimInformation_PoliceReportNo = value; }
        }

        string _Edit_ClaimInformation_DataOfLoss;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInformation_DataOfLoss.
        /// </summary>
        [TestVariable("79bd4c6a-990f-46ae-9350-7aa635303c52")]
        public string Edit_ClaimInformation_DataOfLoss
        {
            get { return _Edit_ClaimInformation_DataOfLoss; }
            set { _Edit_ClaimInformation_DataOfLoss = value; }
        }

        string _Edit_ClaimInformation_AmountOfLoss;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInformation_AmountOfLoss.
        /// </summary>
        [TestVariable("c9c6275d-21dd-4f89-afe1-20364b554a79")]
        public string Edit_ClaimInformation_AmountOfLoss
        {
            get { return _Edit_ClaimInformation_AmountOfLoss; }
            set { _Edit_ClaimInformation_AmountOfLoss = value; }
        }

        string _Edit_Claim_Information_StateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable Edit_Claim_Information_StateOfLoss.
        /// </summary>
        [TestVariable("f7e329fb-ab55-44f4-aa9f-65f3b33ec8ca")]
        public string Edit_Claim_Information_StateOfLoss
        {
            get { return _Edit_Claim_Information_StateOfLoss; }
            set { _Edit_Claim_Information_StateOfLoss = value; }
        }

        string _Edit_Claim_Information_DeductibleAmount;

        /// <summary>
        /// Gets or sets the value of variable Edit_Claim_Information_DeductibleAmount.
        /// </summary>
        [TestVariable("cb9cad4c-c55b-472b-bc69-93d47adb47e0")]
        public string Edit_Claim_Information_DeductibleAmount
        {
            get { return _Edit_Claim_Information_DeductibleAmount; }
            set { _Edit_Claim_Information_DeductibleAmount = value; }
        }

        string _Edit_ClaimInformation_City;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInformation_City.
        /// </summary>
        [TestVariable("3d432c8b-56d8-4fe0-8792-634e47400fbb")]
        public string Edit_ClaimInformation_City
        {
            get { return _Edit_ClaimInformation_City; }
            set { _Edit_ClaimInformation_City = value; }
        }

        string _Edit_ClaimInfroamtion_AccidentType;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInfroamtion_AccidentType.
        /// </summary>
        [TestVariable("7ccfc993-27bc-47af-a0a9-4d3904e7ace5")]
        public string Edit_ClaimInfroamtion_AccidentType
        {
            get { return _Edit_ClaimInfroamtion_AccidentType; }
            set { _Edit_ClaimInfroamtion_AccidentType = value; }
        }

        string _Edit_ClaimInformation_IncidentFacts;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInformation_IncidentFacts.
        /// </summary>
        [TestVariable("c93be362-d7bb-4608-86fc-5d2eb24319e3")]
        public string Edit_ClaimInformation_IncidentFacts
        {
            get { return _Edit_ClaimInformation_IncidentFacts; }
            set { _Edit_ClaimInformation_IncidentFacts = value; }
        }

        string _ClaimInformation_Afni_Liability;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Afni_Liability.
        /// </summary>
        [TestVariable("26d90097-d06c-4875-a8d8-7a14c83bedc1")]
        public string ClaimInformation_Afni_Liability
        {
            get { return _ClaimInformation_Afni_Liability; }
            set { _ClaimInformation_Afni_Liability = value; }
        }

        string _Edit_Claim_Afni_Liability;

        /// <summary>
        /// Gets or sets the value of variable Edit_Claim_Afni_Liability.
        /// </summary>
        [TestVariable("6041aab5-32b3-4699-8b51-b438817f2867")]
        public string Edit_Claim_Afni_Liability
        {
            get { return _Edit_Claim_Afni_Liability; }
            set { _Edit_Claim_Afni_Liability = value; }
        }

        string _ClaimInformation_Client_Liability;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_Client_Liability.
        /// </summary>
        [TestVariable("d310257a-3eb6-4721-a420-16f6742d64e0")]
        public string ClaimInformation_Client_Liability
        {
            get { return _ClaimInformation_Client_Liability; }
            set { _ClaimInformation_Client_Liability = value; }
        }

        string _Edit_ClaimInfomation_Client_Liability;

        /// <summary>
        /// Gets or sets the value of variable Edit_ClaimInfomation_Client_Liability.
        /// </summary>
        [TestVariable("1b677a74-7e87-46c9-a89e-97d49f85982c")]
        public string Edit_ClaimInfomation_Client_Liability
        {
            get { return _Edit_ClaimInfomation_Client_Liability; }
            set { _Edit_ClaimInfomation_Client_Liability = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ReviewSubmissionInformationBelow'", repo.ApplicationUnderTest.ReviewSubmissionInformationBelowInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.ReviewSubmissionInformationBelowInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Review Claim Information') on item 'ApplicationUnderTest.ReviewSubmissionInformationBelow'.", repo.ApplicationUnderTest.ReviewSubmissionInformationBelowInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ReviewSubmissionInformationBelowInfo, "InnerText", "Review Claim Information");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit_Review' at Center.", repo.ApplicationUnderTest.Submit_ReviewInfo, new RecordItemIndex(2));
            //repo.ApplicationUnderTest.Submit_Review.Click();
            //Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Actions_Button'", repo.ApplicationUnderTest.Actions_ButtonInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            //repo.ApplicationUnderTest.Actions_ButtonInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Resolved-Completed') on item 'ApplicationUnderTest.CaseStatus_Resolved_Completed'.", repo.ApplicationUnderTest.CaseStatus_Resolved_CompletedInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.CaseStatus_Resolved_CompletedInfo, "InnerText", "Resolved-Completed");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
