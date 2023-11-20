using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace AutoPilot_for_low_code_examples
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace AutoPilot_for_low_code_examples.ObjectRepository
{
    public static class Descriptors
    {
        public static class UiBank_Admin
        {
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Accounts Accounts { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Accounts();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Login_Page Login_Page { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Login_Page();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Quotes Quotes { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Quotes();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Sidebar Sidebar { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Sidebar();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Users Users { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin.__Users();
        }

        public static class UiBank_Web_App
        {
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Apply_For_Loan Apply_For_Loan { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Apply_For_Loan();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Home Home { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Home();
            public static AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Loan_Application Loan_Application { get; private set; } = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App.__Loan_Application();
        }
    }
}

namespace AutoPilot_for_low_code_examples._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class ___Filter___Refresh : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Filter___Refresh(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/KXOG5ThvLkaQiWT1tIet7A", DisplayName = "&Filter / Refresh", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Account__ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Account__(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/9hiU6d1H8E2Y9ZEbfxfmnw", DisplayName = "Account #", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Balance : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Balance(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/EjpFkkkmnk6LB2cMwkXPZQ", DisplayName = "Balance", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Bank_Code : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Bank_Code(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/PFPdJgMdmU2wQaeLZC42Pw", DisplayName = "Bank Code", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Checking : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Checking(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/9HLxeQxPf0SerENugXJF1A", DisplayName = "Checking", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Delete_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Delete_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/sscXLZUTuEOLWyCcJWax9w", DisplayName = "Delete Account", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Name : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Name(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/gf8VGT0VgESX5hTZylGonQ", DisplayName = "Name", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __New_Account : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Account(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/itnW9mAmLUSgkmIeRq1-4w", DisplayName = "New Account", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Open_Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Open_Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Wi3k-Nx1y0Sl9KRNdW-Gvw", DisplayName = "Open Date", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Accounts
    {
        public class __Savings : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Savings(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/F9X0-aaWyEiX6uxR5sjmBQ", DisplayName = "Savings", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin
    {
        public class __Accounts : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Accounts()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/SSYSyIUNPUahpV7RtXABqg", DisplayName = "Accounts", Screen = this};
                _Filter___Refresh = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.___Filter___Refresh(this, null);
                Account__ = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Account__(this, null);
                Balance = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Balance(this, null);
                Bank_Code = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Bank_Code(this, null);
                Checking = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Checking(this, null);
                Delete_Account = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Delete_Account(this, null);
                Name = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Name(this, null);
                New_Account = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__New_Account(this, null);
                Open_Date = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Open_Date(this, null);
                Savings = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Savings(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.___Filter___Refresh _Filter___Refresh { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Account__ Account__ { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Balance Balance { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Bank_Code Bank_Code { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Checking Checking { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Delete_Account Delete_Account { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Name Name { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__New_Account New_Account { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Open_Date Open_Date { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Accounts.__Savings Savings { get; private set; }
        }
    }

    namespace _UiBank_Admin._Login_Page
    {
        public class __Cancel : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Cancel(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/1wxIOZ94r02MOOYDpWPXWg", DisplayName = "Cancel", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Login_Page
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/NmfGfUWGS0aZ7G9V4H21cw", DisplayName = "Password", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Login_Page
    {
        public class __Submit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Bt9Ns6FH_UKPHGs58rAW0Q", DisplayName = "Submit", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Login_Page
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/-HwdMSlkP0SXAIkNUEy4pA", DisplayName = "Username", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Login_Page
    {
        public class __WindowsForms10_BUTTON_a_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __WindowsForms10_BUTTON_a_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/AIdHNZz2JEaUSFP7AeHxtg", DisplayName = "WindowsForms10.BUTTON.a…", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin
    {
        public class __Login_Page : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Login_Page()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/2n30ECPq-0CP8vZm_GX3FQ", DisplayName = "Login Page", Screen = this};
                Cancel = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Cancel(this, null);
                Password = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Password(this, null);
                Submit = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Submit(this, null);
                Username = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Username(this, null);
                WindowsForms10_BUTTON_a_ = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__WindowsForms10_BUTTON_a_(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Cancel Cancel { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Password Password { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Submit Submit { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__Username Username { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Login_Page.__WindowsForms10_BUTTON_a_ WindowsForms10_BUTTON_a_ { get; private set; }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class ___Filter___Refresh : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Filter___Refresh(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/ccXrHMJQJkuFiNwupFMsYw", DisplayName = "&Filter / Refresh", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/sC6lcxHwmESh6X-NkNv6Fw", DisplayName = "Age", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Amount : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Amount(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/yLOVQepKCEe8S0UQxA-WaA", DisplayName = "Amount", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Approved : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Approved(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/wMSgXa1W7U6CpyiMO7wqYA", DisplayName = "Approved", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Delete_Quote : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Delete_Quote(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/0vKQoLlb9EGujdvfmoaf6g", DisplayName = "Delete Quote", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Edit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Edit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Oik82udLCUGBcLLxirqt-w", DisplayName = "Edit", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __New_Quote : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Quote(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/PAMo1gkdmUCRamtza7GV7g", DisplayName = "New Quote", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Quote_ID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Quote_ID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/n9NEJb-jzUaiuohyB69cdQ", DisplayName = "Quote ID", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Refused : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Refused(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/r5psny2nR02mTzlg3QaYKA", DisplayName = "Refused", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Quotes
    {
        public class __Yearly_income : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Yearly_income(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/3HHrx04RiEq_cbKoOpZpsg", DisplayName = "Yearly income", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin
    {
        public class __Quotes : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Quotes()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/GlQGKTyMYUafCEiLqor-dA", DisplayName = "Quotes", Screen = this};
                _Filter___Refresh = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.___Filter___Refresh(this, null);
                Age = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Age(this, null);
                Amount = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Amount(this, null);
                Approved = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Approved(this, null);
                Delete_Quote = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Delete_Quote(this, null);
                Edit = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Edit(this, null);
                New_Quote = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__New_Quote(this, null);
                Quote_ID = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Quote_ID(this, null);
                Refused = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Refused(this, null);
                Yearly_income = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Yearly_income(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.___Filter___Refresh _Filter___Refresh { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Age Age { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Amount Amount { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Approved Approved { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Delete_Quote Delete_Quote { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Edit Edit { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__New_Quote New_Quote { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Quote_ID Quote_ID { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Refused Refused { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Quotes.__Yearly_income Yearly_income { get; private set; }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class ___80 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___80(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Im4Kh7nBP0mgJku6OF4g6Q", DisplayName = "80", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Accounts : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Accounts(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Iw9WvtgI40eM3vvrer_XFQ", DisplayName = "Accounts", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Date : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Date(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/5sL2sQARWkKRYXxPwvOZgw", DisplayName = "Date", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Debit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Debit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/jnBchBH_VUSoHDUYMpfRGQ", DisplayName = "Debit", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Description : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Description(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/fFBw3vu__UmXdLvphl_V_w", DisplayName = "Description", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Dispute : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Dispute(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/QybrDWvzR0CVGUgswObW2g", DisplayName = "Dispute", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __New_Transaction : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Transaction(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/DYQaWubXVkuCXvM1tawQ1g", DisplayName = "New Transaction", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Quotes : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Quotes(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/PNABBt38Mke6efGP09ySgw", DisplayName = "Quotes", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Reference : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Reference(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/gD12doiEtUWU0iFzIYJoiw", DisplayName = "Reference", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Settings : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Settings(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/2yJEgCODEEymDZ8LjbrR-Q", DisplayName = "Settings", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Transactions : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Transactions(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/2NAfXDe_cEOoEy0tajDgkg", DisplayName = "Transactions", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Sidebar
    {
        public class __Users : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Users(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/6K66Ly814E6ZHpHmxlQxdA", DisplayName = "Users", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin
    {
        public class __Sidebar : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Sidebar()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/f4__n0jx6k-hehjFNU_cpg", DisplayName = "Sidebar", Screen = this};
                _80 = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.___80(this, null);
                Accounts = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Accounts(this, null);
                Date = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Date(this, null);
                Debit = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Debit(this, null);
                Description = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Description(this, null);
                Dispute = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Dispute(this, null);
                New_Transaction = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__New_Transaction(this, null);
                Quotes = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Quotes(this, null);
                Reference = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Reference(this, null);
                Settings = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Settings(this, null);
                Transactions = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Transactions(this, null);
                Users = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Users(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.___80 _80 { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Accounts Accounts { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Date Date { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Debit Debit { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Description Description { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Dispute Dispute { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__New_Transaction New_Transaction { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Quotes Quotes { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Reference Reference { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Settings Settings { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Transactions Transactions { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Sidebar.__Users Users { get; private set; }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class ___Filter___Refresh : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Filter___Refresh(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/3oJW-WrkGU6Cyvbz_WPy2g", DisplayName = "&Filter / Refresh", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Admin : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Admin(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/BoOUAy0sLkywFVM6hDQBsA", DisplayName = "Admin", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Clear : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Clear(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/7NR9fzWhVUmiPrhnbzhl3Q", DisplayName = "Clear", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Create_User : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Create_User(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/S-5G29QBHk21wpo1NiOZfg", DisplayName = "Create User", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Customer : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Customer(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/3Q4PQEZfZUKZodMlNiVQyA", DisplayName = "Customer", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Delete_User : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Delete_User(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/IkqIv2lH20u1JxpI0018SA", DisplayName = "Delete User", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/p52zNrnrZkeGrJVKDVVRcw", DisplayName = "Email", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Female : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Female(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Wo_6rh7f9k2QKJQt8CvZgA", DisplayName = "Female", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Firstname : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Firstname(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/xPZ2xD9qSUaYw1BGPK7YzQ", DisplayName = "Firstname", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Lastname : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Lastname(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/6jN1SnXAk0i9niy-1K_jYA", DisplayName = "Lastname", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Male : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Male(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/fkSvKpTzdEyAO8KFIn_bkw", DisplayName = "Male", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Middlename : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Middlename(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Qtft6vg_1Uqh-P5e6zRYOw", DisplayName = "Middlename", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __thomas_stocker : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __thomas_stocker(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/x3sRAlaGhEKaphhP88hyzg", DisplayName = "thomas.stocker", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Title : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Title(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/siKR-_yVg0ezbyP1hMzLvA", DisplayName = "Title", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin._Users
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/HWV1v19MEkKirVPzleOLBw", DisplayName = "Username", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Admin
    {
        public class __Users : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Users()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/RF8LWhCXJUuMYPyacAFFRQ", DisplayName = "Users", Screen = this};
                _Filter___Refresh = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.___Filter___Refresh(this, null);
                Admin = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Admin(this, null);
                Clear = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Clear(this, null);
                Create_User = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Create_User(this, null);
                Customer = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Customer(this, null);
                Delete_User = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Delete_User(this, null);
                Email = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Email(this, null);
                Female = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Female(this, null);
                Firstname = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Firstname(this, null);
                Lastname = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Lastname(this, null);
                Male = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Male(this, null);
                Middlename = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Middlename(this, null);
                thomas_stocker = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__thomas_stocker(this, null);
                Title = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Title(this, null);
                Username = new AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Username(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.___Filter___Refresh _Filter___Refresh { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Admin Admin { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Clear Clear { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Create_User Create_User { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Customer Customer { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Delete_User Delete_User { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Email Email { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Female Female { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Firstname Firstname { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Lastname Lastname { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Male Male { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Middlename Middlename { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__thomas_stocker thomas_stocker { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Title Title { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Admin._Users.__Username Username { get; private set; }
        }
    }

    namespace _UiBank_Web_App._Apply_For_Loan
    {
        public class __Apply_For_A_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Apply_For_A_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/kBHr35QOdECaeJD1z8lRow", DisplayName = "Apply For A Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App
    {
        public class __Apply_For_Loan : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Apply_For_Loan()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Z9DQ8wgeHUKJ5cqsiE_mAQ", DisplayName = "Apply For Loan", Screen = this};
                Apply_For_A_Loan = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Apply_For_Loan.__Apply_For_A_Loan(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Apply_For_Loan.__Apply_For_A_Loan Apply_For_A_Loan { get; private set; }
        }
    }

    namespace _UiBank_Web_App._Home
    {
        public class __Loans : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loans(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/GwPXvLa8OEKi6DbjHqdgWQ", DisplayName = "Loans", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App._Home
    {
        public class __Products : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Products(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/-bDk34Q-L0SSnxKtWEiexQ", DisplayName = "Products", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App
    {
        public class __Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/_-C26gY1WEmDXrzesfxPvg", DisplayName = "Home", Screen = this};
                Loans = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Home.__Loans(this, null);
                Products = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Home.__Products(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Home.__Loans Loans { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Home.__Products Products { get; private set; }
        }
    }

    namespace _UiBank_Web_App._Loan_Application
    {
        public class __Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/RBd9UopJOkCKdaiLB8nq1Q", DisplayName = "Email", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App._Loan_Application
    {
        public class __Loan_Amount_Requested : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount_Requested(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/gs9UgmEWrE-TBCHdAUzeKw", DisplayName = "Loan Amount Requested", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App._Loan_Application
    {
        public class __Loan_Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/LD_8IZG1DEC7u4zfwf98rQ", DisplayName = "Loan Term", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiBank_Web_App
    {
        public class __Loan_Application : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Loan_Application()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "XmPyalMSikOXyDwqk_uXgg/Eiogt8INmUy2KqH3yvFMnQ", DisplayName = "Loan Application", Screen = this};
                Email = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Email(this, null);
                Loan_Amount_Requested = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Loan_Amount_Requested(this, null);
                Loan_Term = new AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Loan_Term(this, null);
            }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Email Email { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Loan_Amount_Requested Loan_Amount_Requested { get; private set; }

            public AutoPilot_for_low_code_examples._Implementation._UiBank_Web_App._Loan_Application.__Loan_Term Loan_Term { get; private set; }
        }
    }
}