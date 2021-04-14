signtool sign /f KtecK_Labs.p12 /d "StreamDesk" /du "http://streamdesk.ca" bin\StreamDesk.exe bin\StreamDesk.Framework.dll mac-bin\StreamDesk.Core.exe mac-bin\StreamDesk.Framework.dll
Tools\NSLicGen.exe bin\StreamDesk.exe bin\Licencee.xml
Tools\XmlSigner.exe KtecK_Labs.p12 bin\Licencee.xml