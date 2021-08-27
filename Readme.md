<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623076/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T183237)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Class1.cs](./CS/ClassLibrary1/Class1.cs) (VB: [Class1.vb](./VB/ClassLibrary1/Class1.vb))
* [Form1.cs](./CS/T183237/Form1.cs) (VB: [Form1.vb](./VB/T183237/Form1.vb))
* [Program.cs](./CS/T183237/Program.cs) (VB: [Program.vb](./VB/T183237/Program.vb))
<!-- default file list end -->
# ImageCollection - How to use images from a solution-wide resource assembly


<p>- Generate a new project in your solution (ClassLibrary1) using standard Visual Studio Solution -> Add -> New Project... drop-down menu;</p>
<p>Note that generally it's not necessary to have an image class library project as a part of your solution. You can have one assembly with all the necessary images (icons) and use it in all the solutions using our <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressUtilsImageCollectiontopic">ImageCollection</a> component.</p>
<p>- Copy your icons in the new project directory and include them in the project as <strong>Embedded Resource</strong>:</p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/imagecollection-how-to-use-images-from-a-solution-wide-resource-assembly-t183237/14.2.3+/media/9ee1568d-8aac-11e4-80ba-00155d624807.png"></p>
<p>- Add the reference to your assembly (ClassLibrary1) to the necessary project;<br />- Drag and drop an ImageCollection component from the Toolbox to your form;<br />- Click a smart tag (a small black triangle) and select the <strong>From Referenced Assemblies</strong> item of the shown drop-down menu to obtain your images.</p>
<p><img src="https://raw.githubusercontent.com/DevExpress-Examples/imagecollection-how-to-use-images-from-a-solution-wide-resource-assembly-t183237/14.2.3+/media/243ab7dd-8aad-11e4-80ba-00155d624807.png"></p>
<p>Then, you will be able to use your images from the assembly as usual.</p>
<p>Refer to the the attached video and <a href="https://www.devexpress.com/Support/Center/p/T183237">ImageCollection - How to use images from a solution-wide resource assembly</a> ticket for the example illustrating how it works in action.</p>

<br/>


