using AmazonScenarios.Amazon;
using System;
using TechTalk.SpecFlow;

namespace AmazonScenarios
{
    [Binding]
    public class AmazonScenarioSteps
    {
        Homepage hp = new Homepage();
        AddAddress ad = new AddAddress();
        ModifyAddress ma = new ModifyAddress();
        DeleteAddress da = new DeleteAddress();
        SearchProduct sp = new SearchProduct();
        LogoutAndLoginBack lg = new LogoutAndLoginBack();
        [Given(@"Iam at Amazon HomePage")]
        public void GivenIamAtAmazonHomePage()
        {
            hp.IamAtHomePage();
        }
        
        [Given(@"I Click Signin link, login Page is Displayed")]
        public void GivenIClickSigninLinkLoginPageIsDisplayed()
        {
            hp.SignIn();
        }
        
        [Given(@"I Enter MobileNumber")]
        public void GivenIEnterMobileNumber()
        {
            hp.EnterMobileNumber();
        }
        
        [Given(@"I click Continue Button")]
        public void GivenIClickContinueButton()
        {
            hp.Continue();
        }
        
        [Given(@"I Enter Password")]
        public void GivenIEnterPassword()
        {
            hp.EnterPassword();
        }
        
        [Given(@"I click Your orders link")]
        public void GivenIClickYourOrdersLink()
        {
            ad.ClickYourorders();
        }
        
        [Given(@"I press Your Address")]
        public void GivenIPressYourAddress()
        {
            ad.clickYourAddress();
        }
        
        [Given(@"I Click Add Address link")]
        public void GivenIClickAddAddressLink()
        {
            ad.clickAddAddress();
        }
        
        [Given(@"I Enter Adderss Details")]
        public void GivenIEnterAdderssDetails()
        {
            ad.AddAddressDetails();
        }
        
        [Given(@"I click Edit")]
        public void GivenIClickEdit()
        {
            ma.clickEdit();
        }
        
        [Given(@"I modify Address Details")]
        public void GivenIModifyAddressDetails()
        {
            ma.modifyAddressDetails();
        }
        
        [Given(@"I click Delete")]
        public void GivenIClickDelete()
        {
            da.clickDelete();
        }
        
        [Given(@"I enter Product name in Search box")]
        public void GivenIEnterProductNameInSearchBox()
        {
            sp.searchProduct();
        }
        
        [Given(@"i click on Search Symbol")]
        public void GivenIClickOnSearchSymbol()
        {
            sp.clickSearch();
        }
        
        [Given(@"I click On the product")]
        public void GivenIClickOnTheProduct()
        {
            sp.ClickOnProduct();
        }
        
        [Given(@"I click Add to cart")]
        public void GivenIClickAddToCart()
        {
            sp.Addtocart();
        }
        
        [Given(@"I place cursor on Your orders link")]
        public void GivenIPlaceCursorOnYourOrdersLink()
        {
            lg.PlaceCursor();
        }
        
        [Given(@"I Click Signout link, login page is displayed")]
        public void GivenIClickSignoutLinkLoginPageIsDisplayed()
        {
            lg.ClickSignout();
        }
        
        [Given(@"I Search Shoes name in Search box")]
        public void GivenISearchShoesNameInSearchBox()
        {
            sp.SearchShoes();
        }
        
        [Given(@"I press enter")]
        public void GivenIPressEnter()
        {
            sp.clickSearch();
        }
        
        [Given(@"I click on Shoes")]
        public void GivenIClickOnShoes()
        {
            sp.selectShoes();
        }
        
        [Given(@"I Select the size")]
        public void GivenISelectTheSize()
        {
            sp.Selectsize();
        }
        
        [When(@"I Click Login Button")]
        public void WhenIClickLoginButton()
        {
            hp.Login();
        }
        
        [When(@"I Press Add Address Button")]
        public void WhenIPressAddAddressButton()
        {
            ad.clickAddAddressButton();
        }
        
        [When(@"I click Save Changes")]
        public void WhenIClickSaveChanges()
        {
            ma.clickSavechages();
        }
        
        [When(@"I press yes Button")]
        public void WhenIPressYesButton()
        {
            da.Confirmation();
        }
        
        [When(@"I click Proceed to buy")]
        public void WhenIClickProceedToBuy()
        {
            sp.ProceedToPay();
        }
        
        [When(@"I click BuyNow option")]
        public void WhenIClickBuyNowOption()
        {
            sp.ClickBuynow();
        }
        
        [Then(@"I log into my Amazon Account")]
        public void ThenILogIntoMyAmazonAccount()
        {
            hp.Result();
        }
        
        [Then(@"Address Should be Added")]
        public void ThenAddressShouldBeAdded()
        {
            ad.AddAddressResult();
        }
        
        [Then(@"Address is saved")]
        public void ThenAddressIsSaved()
        {
            ma.ModifyResult();
        }
        
        [Then(@"Address is Deleted")]
        public void ThenAddressIsDeleted()
        {
            da.DeleteResult();
        }
        
        [Then(@"Page Navigates to Payment Options")]
        public void ThenPageNavigatesToPaymentOptions()
        {
            sp.PaymentPageResult();
        }
        
        [Then(@"It Navigates to Payment page")]
        public void ThenItNavigatesToPaymentPage()
        {
            sp.NavigatetoPaymentResult();
        }
    }
}
