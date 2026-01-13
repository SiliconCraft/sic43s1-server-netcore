# SIC43S1 Tag authenticity verification using Smart Authenticated Code

This project provides an example ASP.NET Core project for SIC43S1 Smart Authenticated Code authentication on web application. SIC43S1 tag provider can apply this concept to allow SIC43S1 tag holders to verify theirs tags as well as communicate to them regarding the tag status.

**Table of Content**
* [Basic Concept of SIC43S1](#Basic-Concept-of-SIC43S1)
* [Getting Started](#Getting-Started)
  * [Installing on Microsoft Azure Web App](#Installing-on-Microsoft-Azure-Web-App) 
  * [Installing on Google Cloud Platform](#Installing-on-Google-Cloud-Platform)
* [Usage](#Usage) 

## Basic Concept of SIC43S1

SIC43S1 Tag provides 4 distinct NDEF contents coded in Hexadecimal string which can be pass to web service directly. The contents including
1. **UID** or **Unique ID** **:** 7-bytes UID of this Tag (i.e. "39493000012345")
1. **Temporary Flag:** 1-byte content of temporary pin. 
1. **Time-Stamp:** 4-bytes randomly increasing value (each step of increasing is 1 to 255). This content always increases each time the tag has been read.
1. **Smart Authenticated Code:** 16-bytes of stream cipher with input from Time-stamp, Temporary Flag and UID.

## Getting Started

### Installing on Microsoft Azure Web App

#### Prerequisites

* SIC43S1 Tag
* Android NFC Phone with [SIC43S1 Writer](https://play.google.com/store/apps/details?id=com.sic.s1writer) App
* [Microsoft Azure Account](https://azure.microsoft.com/) 
* [Azure Command Line / Azure CLI](https://docs.microsoft.com/en-us/cli/azure) from [Azure Cloud Shell](https://docs.microsoft.com/en-us/azure/cloud-shell/overview) in Azure Portal or locally [install](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli?view=azure-cli-latest) on your macOS, Linux or Window machine.

#### Step 1 : Create a resource group

Create a new resource group to contain this new sample web app by using Azure command line.
The following example creates a new resource group which requires a name and its location (i.e. "West Europe"). 

```
az group create --name <your-resource-group-name> --location <your-server-location>
```

#### Step 2 : Create a new Free App Service Plan
Create a new Free App Service Plan by using Azure command line. The following example creates a new Free App service plan name in your resource group from step 1.

```
az appservice plan create --name <your-service-plan-name> --resource-group <your-resource-group-name> --sku FREE
```

#### Step 3 : Create a Web App 
Create a new Web App by using Azure command line. The following example creates a new Web App. Please replace <app_name> with a globally unique application name (valid characters are 'a-z', '0-9', and '-'). 

```
az webapp create --resource-group <your-resource-group-name> --plan <your-service-plan-name> --name <app_name>
```

#### Step 4 : Deploy the sample app using Git
Deploy source code from GitHub to Azure Web App using Azure command line. The following example deploys source code from https://github.com/SiliconCraft/sic43s1-server-netcore.git in master branch to a Web App name <app_name> in resource group <your-resource-group-name>.

```
az webapp deployment source config --repo-url https://github.com/SiliconCraft/sic43s1-server-netcore.git --branch master  --name <app_name> --resource-group <your-resource-group-name> --manual-integration
```

#### Step 5 : Customize SIC43S1 Tag
Use SIC43S1 Writer App on Android NFC Phone to customize SIC43S1 Tag as the explanation below.

* SAC setting (In case of default tag, this SAC mode can leave with default factory value)
  * **'DYNAMIC DATA' tab**
    * Smart Authenticated Code keeps changing.
  * **'ENCRYPTION SETTING' tab**
    * FFFF + Tag UID + Tag UID (i.e. The SAC Key of the Tag with UID = "39493000012345" is "FFFF3949300001234539493000012345".)

* NDEF MESSAGE Tab
  * **Check mode of IC before setting NDEF.**
  * **Prefix:** https://
  * **NDEF Message:** <app_name>.azurewebsites.net
  * **Dynamic Data**
    * **Parameter 1:** "U"
    * **Parameter 2:** "TF"
    * **Parameter 3:** "TS"
    * **Parameter 4:** "SAC"

After completely customize SIC43S1 Tag with the setting above, each time you tap the SIC43S1 tag to NFC Phone (iPhone, Android or any NDEF support device), the web page will display a table of Temporary Flag, Time Stamp value and Smart Authenticated Code value which keep changing. Especially for the smart authenticated code value, it will be a match between "From Tag" and "From Server" column. This mean that server-side application (which calculate smart authenticated code based on same Smart Authenticated Code Key) can check the authenticity of SIC43S1 Tag.

### Installing on Google Cloud Platform

#### Prerequisites

* SIC43S1 Tag
* Android NFC Phone with [SIC43S1 Writer](https://play.google.com/store/apps/details?id=com.sic.s1writer) App
* [Google Cloud Console Account](https://console.cloud.google.com/) 
* Google Cloud App Engine

#### Step 1 : Creating and managing projects
 
Google Cloud projects form the basis for creating and using all Google Cloud services. 
To create and manage Google Cloud project using Google Cloud Console, please follow the step in [Creating and managing projects](https://cloud.google.com/resource-manager/docs/creating-managing-projects#creating_a_project)

#### Step 2 : Creating App Engine 

1. Click "Go to the [Dashboard page](https://console.cloud.google.com/home?_ga=2.205273744.1217504798.1597994442-2063354042.1597316606)" in the Cloud console
2. select your project name on top left corner.
3. click Activate Cloud Shell on top right corner to use browser shell command.
4. update all component and continue update press "Y" (Optional)

```
sudo apt-get update && sudo apt-get --only-upgrade install google-cloud-sdk-bigtable-emulator google-cloud-sdk-datastore-emulator google-cloud-sdk-cbt google-cloud-sdk-pubsub-emulator google-cloud-sdk-app-engine-python-extras google-cloud-sdk-minikube google-cloud-sdk-app-engine-python kubectl google-cloud-sdk-kpt google-cloud-sdk google-cloud-sdk-app-engine-go google-cloud-sdk-firestore-emulator google-cloud-sdk-app-engine-grpc google-cloud-sdk-cloud-build-local google-cloud-sdk-datalab google-cloud-sdk-anthos-auth google-cloud-sdk-kind google-cloud-sdk-spanner-emulator google-cloud-sdk-skaffold google-cloud-sdk-app-engine-java
```

#### Step 3 : Clone the git sample app using Google Cloud Shell

1. Clone source code from GitHub to Google Cloud Platform using Google Cloud Shell. The following example deploy source code from the master branch of https://github.com/SiliconCraft/sic43s1-server-netcore.git
```
git clone https://github.com/SiliconCraft/sic43s1-server-netcore.git
```

2. Move the directory into the project folder
```
cd sic43s1-server-netcore/sic43s1-netcore
```

3. run the ASP.NET Core app on port 8080
```
dotnet run --urls=http://localhost:8080
```

4. view the app in your cloud shell toolbar, click "Web preview" and select "Preview on port 8080.".

5. publish the ASP.NET Core app by the following command
```
dotnet publish -c Release
```

6. Move the directory into publish folder
```
cd bin/Release/netcoreapp3.1/publish/
```

7. Create app.yaml for App engine flexible.
```
vim app.yaml
```
write this code to app.yaml file
```
runtime: aspnetcore
env: flex
```

#### Step 4 : Deploy and run

Deploy app on App Engine by the following command

```
gcloud app deploy --version v1
```

view the live app by the following command

```
gcloud app browse
```

then you will see the url link on the console, Go to this link to view your app.

For more information, please find [Quickstart for ASP.NET Core](https://codelabs.developers.google.com/codelabs/cloud-app-engine-aspnetcore/#0)

#### Step 5 : Customize SIC43S1 Tag
Use SIC43S1 Writer App on Android NFC Phone to customize SIC43S1 Tag as the explanation below.
* SAC setting (In case of default tag, this SAC mode can leave with default factory value)
  * **'DYNAMIC DATA' tab**
    * Smart Authenticated Code keeps changing.
  * **'ENCRYPTION SETTING' tab**
    * FFFF + Tag UID + Tag UID (i.e. The SAC Key of the Tag with UID = "39493000012345" is "FFFF3949300001234539493000012345".)

* NDEF MESSAGE Tab
  * **Check mode of IC before setting NDEF.**
  * **Prefix:** https://
  * **NDEF Message:** <PROJECT_ID>.<REGION_ID>.r.appspot.com
  * **Dynamic Data**
    * **Parameter 1:** "U"
    * **Parameter 2:** "TF"
    * **Parameter 3:** "TS"
    * **Parameter 4:** "SAC"

After completely customize SIC43S1 Tag with the setting above, each time you tap the SIC43S1 tag to NFC Phone (iPhone, Android or any NDEF support device), the web page will display a table of Temporary Flag, Time Stamp value and Smart Authenticated Code value which keep changing. Especially for the smart authenticated code value, it will be a match between "From Tag" and "From Server" column. This mean that server-side application (which calculate smart authenticated code based on same Smart Authenticated Code Key) can check the authenticity of SIC43S1 Tag.


## Usage

For a general use-case of authenticity verification with SIC43S1, the consistence of smart authenticated code and the increasing of timestamp value must be verified.

### 1: Verify consistence of smart authenticated code

To verify consistence of smart authenticated code, you can use AES-CMAC from Bouncy Castle Crypto APIs for smart authenticated code calculation. 

you can working with the library: 

```
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
```

select mode of AES using *GetMac()*, add 128 bit-key to *KeyParameter()* then put the key for encryption using *mac.Init()*. you can encrypt cipher text using *mac.BlockUpdate()* and get cipher text by *MacUtilities.DoFinal()*

```
IMac mac = MacUtilities.GetMac("AESCMAC");
KeyParameter key = new KeyParameter(keyBytes128);
mac.Init(key);
mac.BlockUpdate(plaintext, 0, plaintext.Length);
byte[] cmac = MacUtilities.DoFinal(mac);
```

The Bouncy Castle Crypto APIs calculate smart authenticated code. It requires *128 bits-Key* (input as a 32-characters hexadecimal string) and *32 bits Time Stamp* + *28 bits UID* + *8 bits of Temporary Flag* or *68 bits iv* (input as a 17-characters hexadecimal string).

### 2: Verify increasing of time-stamp value

To verify increasing of time-stamp value, you need data storage to keep latest time-stamp value of each tag (each UID). Please note that this repository does not provide the example to store latest time-stamp in server at the moment. However the logic is quite simple, any web page request with time-stamp value less or equal the latest successful smart authenticated code verification time-stamp value should be consider as a reuse of URL which should be reject.


## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details
