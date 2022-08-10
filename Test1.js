
describe('Ryze', function () {
    browser.ignoreSynchronization = false; // for non-angular websites
    browser.manage().timeouts().implicitlyWait(50000)
    let originalTimeout;

    beforeEach(() => {
        originalTimeout = jasmine.DEFAULT_TIMEOUT_INTERVAL;
        jasmine.DEFAULT_TIMEOUT_INTERVAL = 10000;
    });

    it("takes a long time", (done) => {
        setTimeout(() => {
            done();
        }, 9000);
    });

    afterEach(() => {
        jasmine.DEFAULT_TIMEOUT_INTERVAL = originalTimeout;
    });
});
    it('Validate sign in', function () {
        browser.get('https://ryze-staging.formedix.com/sign-in');
        element(by.id('username')).sendKeys('testteamtechtest');
        element(by.id('password')).sendKeys('T3st3rT3ch');

        element(by.id('btnSubmit')).click();

        expect(browser.getCurrentUrl()).toEqual("https://ryze-staging.formedix.com/#/08a379ed-eed1-4502-be5f-2c7b086b0b4b/dashboard");
        
    });
    it('Medical history page navigation', function () {

        browser.sleep(20000);

        element(by.xpath("//p[. = 'Repository']")).click();//repository
        element(by.css("#menuMdbStudies")).click(); // menu list studies
        element(by.css("#fdxMdbContainerListItem0MenuToggle")).click(); //menu toggle
        element(by.css("#fdxMdbContainerListItem0View")).click();// view list 
        element(by.css("#ViewAssetGroupdataAcquisition")).click();//data aquisition
        element(by.css("#FORMTypeView")).click();//click form type
        element(by.xpath("//div[4]/div//div[2]")).click();//click Med Hist

        expect(browser.getCurrentUrl()).toEqual("https://ryze-staging.formedix.com/#/08a379ed-eed1-4502-be5f-2c7b086b0b4b/containers/STUDY/28e314bd-cf26-4a0b-a39a-502ddbe2cd6a/1/asset/c70688b5-7bb1-40d6-87df-07e974673232?assetType=FORM&mode=view&panel=browsing&assetGroupType=DATA_ACQUISITION&assetGroupAid=a5e0f205-e678-4ef3-8818-9a1a64f0afd2");

  

       


    });
    it('Validate description is save by page loader', function () {
        element(by.id("switchEditMode")).click(); //edit form button
        element(by.xpath("//div[6]/fdx-mdb-asset-edit-prop/div/div[1]/div/span[1]")).click();
        element(by.css("#assetLocaleEditTextTextareadescription")).click();// Description Field
        element(by.css("#assetLocaleEditTextTextareadescription")).sendKeys('Validate the description field if stings can be insertedd');
        element(by.css("#localeInputdescription")).click();
        element(by.xpath("//div/div/ul/li[1]/a")).click();
        element(by.css("#saveAsset")).click();

        //element(by.id("switchEditMode")).click(); //edit form button

        expect(element(by.xpath("//*[name()='path']")).isPresent()).toBe(true);//page loader if present update is sucessful 
        expect(element(by.xpath("//fdx-mdb-asset-edit-view/div/div[3]/div/div/span/span")).isPresent()).toBe(true);
      

    });

    it('Validate description is updatedd from main view', function () {
        browser.sleep(10000)
        element(by.id("switchEditMode")).click(); //edit form button
        expect(element(by.id('formDescription')).getText()).toEqual('Validate the description field if stings can be insertedd');/// get field value

    });

    it('Validate that User is Log Out User', function () {
        element(by.xpath("//ul[2]/li[2]//p[1]")).click();
        element(by.xpath("//span[. = 'Sign out']")).click();
        expect(browser.getTitle()).toEqual('Sign in - ryze');
    });
    

    



        
