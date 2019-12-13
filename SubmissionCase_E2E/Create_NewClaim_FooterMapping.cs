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
    ///The Create_NewClaim_FooterMapping recording.
    /// </summary>
    [TestModule("ebe71c98-6429-436d-88c7-bb0c900f5487", ModuleType.Recording, 1)]
    public partial class Create_NewClaim_FooterMapping : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Create_NewClaim_FooterMapping instance = new Create_NewClaim_FooterMapping();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create_NewClaim_FooterMapping()
        {
            ClaimInformation_ClientName = "";
            ClaimInformation_ClaimNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create_NewClaim_FooterMapping Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClaimInformation_ClientName;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClientName.
        /// </summary>
        [TestVariable("6e44d2f4-4f13-48cd-ac5b-7b93b451e9d9")]
        public string ClaimInformation_ClientName
        {
            get { return _ClaimInformation_ClientName; }
            set { _ClaimInformation_ClientName = value; }
        }

        string _ClaimInformation_ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable ClaimInformation_ClaimNumber.
        /// </summary>
        [TestVariable("7a0f2acc-4e33-4b9f-84dd-eab6c68b0821")]
        public string ClaimInformation_ClaimNumber
        {
            get { return _ClaimInformation_ClaimNumber; }
            set { _ClaimInformation_ClaimNumber = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(0));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 360 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Footer_ClaimInfo' at 39;4.", repo.ApplicationUnderTest.Footer_ClaimInfoInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Footer_ClaimInfo.Click("39;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Client Name') on item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName_Header'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName_HeaderInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName_HeaderInfo, "InnerText", "Client Name");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName' and assigning its value to variable 'ClaimInformation_ClientName'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientNameInfo, new RecordItemIndex(4));
            ClaimInformation_ClientName = repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_ClientName, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ClaimInformation_ClientName) on item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClientName'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientNameInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClientNameInfo, "InnerText", ClaimInformation_ClientName);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ClaimInformation_ClaimNumber) on item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber_Header'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber_HeaderInfo, new RecordItemIndex(7));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber_HeaderInfo, "InnerText", ClaimInformation_ClaimNumber);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber' and assigning its value to variable 'ClaimInformation_ClaimNumber'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumberInfo, new RecordItemIndex(8));
            ClaimInformation_ClaimNumber = repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", ClaimInformation_ClaimNumber, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ClaimInformation_ClaimNumber) on item 'ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumber'.", repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumberInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_ClaimInfo_ClaimNumberInfo, "InnerText", ClaimInformation_ClaimNumber);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}