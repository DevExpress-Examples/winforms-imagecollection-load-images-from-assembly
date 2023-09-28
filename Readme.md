<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623076/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T183237)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms ImageCollection - Use images from a solution-wide resource assembly

Follow the steps below:

* Create a new project in your solution (`ClassLibrary1`).

  > **Note**
  >
  > It is not necessary to have an image class library project as part of your solution. You can have an assembly with images/icons and use it in different solutions using our [ImageCollection](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ImageCollection) component.

* Copy your images/icons in the new project directory and include them in the project as **Embedded Resource**:
  
  ![WinForms ImageCollection - Use images from a solution-wide resource assembly](https://raw.githubusercontent.com/DevExpress-Examples/imagecollection-how-to-use-images-from-a-solution-wide-resource-assembly-t183237/14.2.3+/media/9ee1568d-8aac-11e4-80ba-00155d624807.png)

* Reference your assembly (`ClassLibrary1`) in the project.
* Drag the `ImageCollection` component from the Toolbox and drop it onto the form.
* Invoke a smart tag menu and select **From Referenced Assemblies**.

  ![WinForms ImageCollection Smart Tag Menu](https://raw.githubusercontent.com/DevExpress-Examples/imagecollection-how-to-use-images-from-a-solution-wide-resource-assembly-t183237/14.2.3+/media/243ab7dd-8aad-11e4-80ba-00155d624807.png)


## Files to Review

* [Class1.cs](./CS/ClassLibrary1/Class1.cs) (VB: [Class1.vb](./VB/ClassLibrary1/Class1.vb))
* [Form1.cs](./CS/T183237/Form1.cs) (VB: [Form1.vb](./VB/T183237/Form1.vb))
