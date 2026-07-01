#### [DiGi\.VoTT](index.md 'index')

## DiGi\.VoTT Namespace
### Classes

<a name='DiGi.VoTT.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.VoTT.Create.Asset(string)'></a>

## Create\.Asset\(string\) Method

Creates an [Asset\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Asset(string) 'DiGi\.VoTT\.Create\.Asset\(string\)') instance from the specified file path\.

```csharp
public static DiGi.VoTT.Classes.Asset? Asset(string? path);
```
#### Parameters

<a name='DiGi.VoTT.Create.Asset(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The system path to the asset file\.

#### Returns
[Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')  
An [Asset\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Asset(string) 'DiGi\.VoTT\.Create\.Asset\(string\)') object if the file exists at the given path; otherwise, `null`\.

<a name='DiGi.VoTT.Create.Asset_ById(string)'></a>

## Create\.Asset\_ById\(string\) Method

Creates an [Asset\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Asset(string) 'DiGi\.VoTT\.Create\.Asset\(string\)') instance using the specified identifier\.

```csharp
public static DiGi.VoTT.Classes.Asset? Asset_ById(string? id);
```
#### Parameters

<a name='DiGi.VoTT.Create.Asset_ById(string).id'></a>

`id` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the asset\.

#### Returns
[Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')  
An [Asset\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Asset(string) 'DiGi\.VoTT\.Create\.Asset\(string\)') object if a valid identifier is provided; otherwise, `null`\.

<a name='DiGi.VoTT.Create.BoundingBox(double,double,double,double)'></a>

## Create\.BoundingBox\(double, double, double, double\) Method

Creates a BoundingBox based on two coordinate points\.

```csharp
public static DiGi.VoTT.Classes.BoundingBox? BoundingBox(double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.VoTT.Create.BoundingBox(double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the first point\.

<a name='DiGi.VoTT.Create.BoundingBox(double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the first point\.

<a name='DiGi.VoTT.Create.BoundingBox(double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the second point\.

<a name='DiGi.VoTT.Create.BoundingBox(double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the second point\.

#### Returns
[BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')  
A [BoundingBox\(double, double, double, double\)](DiGi.VoTT.md#DiGi.VoTT.Create.BoundingBox(double,double,double,double) 'DiGi\.VoTT\.Create\.BoundingBox\(double, double, double, double\)') instance if all coordinates are valid numbers; otherwise, null\.

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string)'></a>

## Create\.Region\(double, double, double, double, string\) Method

Creates a [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') object by defining a bounding box with the specified coordinates and associating it with a tag name\.

```csharp
public static DiGi.VoTT.Classes.Region? Region(double x_1, double y_1, double x_2, double y_2, string tagName);
```
#### Parameters

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the first point of the bounding box\.

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the first point of the bounding box\.

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate of the second point of the bounding box\.

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate of the second point of the bounding box\.

<a name='DiGi.VoTT.Create.Region(double,double,double,double,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to associate with the created region\.

#### Returns
[Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region')  
A new [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') instance if a valid bounding box is created and the tag name is provided; otherwise, `null`\.

<a name='DiGi.VoTT.Create.Region(thisDiGi.VoTT.Classes.BoundingBox,string)'></a>

## Create\.Region\(this BoundingBox, string\) Method

Creates a [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') object from a bounding box and a tag name\.

```csharp
public static DiGi.VoTT.Classes.Region? Region(this DiGi.VoTT.Classes.BoundingBox? boundingBox, string tagName);
```
#### Parameters

<a name='DiGi.VoTT.Create.Region(thisDiGi.VoTT.Classes.BoundingBox,string).boundingBox'></a>

`boundingBox` [BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')

The [BoundingBox\(double, double, double, double\)](DiGi.VoTT.md#DiGi.VoTT.Create.BoundingBox(double,double,double,double) 'DiGi\.VoTT\.Create\.BoundingBox\(double, double, double, double\)') that defines the region's boundaries\.

<a name='DiGi.VoTT.Create.Region(thisDiGi.VoTT.Classes.BoundingBox,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to associate with the created region\.

#### Returns
[Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region')  
A new [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') instance if the bounding box is not null and the tag name is provided; otherwise, `null`\.

<a name='DiGi.VoTT.Create.Region(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string)'></a>

## Create\.Region\(this IEnumerable\<Point\>, string\) Method

Creates a [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') object from a collection of points and a tag name\.

```csharp
public static DiGi.VoTT.Classes.Region? Region(this System.Collections.Generic.IEnumerable<DiGi.VoTT.Classes.Point>? points, string? tagName);
```
#### Parameters

<a name='DiGi.VoTT.Create.Region(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point') objects that define the region's boundary\.

<a name='DiGi.VoTT.Create.Region(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to associate with the created region\.

#### Returns
[Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region')  
A new [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') instance if the points are not null, contain at least three elements, and the tag name is provided; otherwise, `null`\.

<a name='DiGi.VoTT.Create.Size(string)'></a>

## Create\.Size\(string\) Method

Retrieves the dimensions of an image file located at the specified path\.

```csharp
public static DiGi.VoTT.Classes.Size? Size(string? path);
```
#### Parameters

<a name='DiGi.VoTT.Create.Size(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the image\.

#### Returns
[Size](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Size 'DiGi\.VoTT\.Classes\.Size')  
A [Size](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Size 'DiGi\.VoTT\.Classes\.Size') object containing the width and height if the file exists; otherwise, null\.

<a name='DiGi.VoTT.Create.Tag(string)'></a>

## Create\.Tag\(string\) Method

Creates a new [Tag\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Tag(string) 'DiGi\.VoTT\.Create\.Tag\(string\)') instance with the specified name and a default color\.

```csharp
public static DiGi.VoTT.Classes.Tag? Tag(string? name);
```
#### Parameters

<a name='DiGi.VoTT.Create.Tag(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to create\.

#### Returns
[Tag](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Tag 'DiGi\.VoTT\.Classes\.Tag')  
A [Tag\(string\)](DiGi.VoTT.md#DiGi.VoTT.Create.Tag(string) 'DiGi\.VoTT\.Create\.Tag\(string\)') instance if the provided name is not null or whitespace; otherwise, `null`\.

<a name='DiGi.VoTT.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.Asset)'></a>

## Modify\.Add\(this VoTTModel, Asset\) Method

Adds the specified asset to the VoTT model, creating a new entry or updating an existing one based on the asset's identifier\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, DiGi.VoTT.Classes.Asset? asset);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.Asset).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to which the asset is added\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.Asset).asset'></a>

`asset` [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')

The [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset') to be added to the model\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the asset was successfully added or updated; otherwise, `false`\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.AssetData)'></a>

## Modify\.Add\(this VoTTModel, AssetData\) Method

Adds the specified asset data to the VoTT model and processes any associated region tags\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, DiGi.VoTT.Classes.AssetData? assetData);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.AssetData).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to which the asset is added\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,DiGi.VoTT.Classes.AssetData).assetData'></a>

`assetData` [AssetData](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.AssetData 'DiGi\.VoTT\.Classes\.AssetData')

The [AssetData](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.AssetData 'DiGi\.VoTT\.Classes\.AssetData') containing the asset information to be added\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the asset was successfully added; otherwise, `false`\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string)'></a>

## Modify\.Add\(this VoTTModel, string\) Method

Adds a tag with the specified name to the VoTT model if it does not already exist\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, string? tagName);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to which the tag will be added\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to add\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the tag was successfully added or already existed; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.BoundingBox,string)'></a>

## Modify\.Add\(this VoTTModel, string, BoundingBox, string\) Method

Adds a new region to the VoTT model for a specific asset using a bounding box and a tag name\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, string? assetId, DiGi.VoTT.Classes.BoundingBox? boundingBox, string? tagName);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.BoundingBox,string).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to which the region will be added\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.BoundingBox,string).assetId'></a>

`assetId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the asset associated with the region\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.BoundingBox,string).boundingBox'></a>

`boundingBox` [BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')

The [BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox') defining the area of the region\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.BoundingBox,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to assign to the created region\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the region was successfully added; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.Region)'></a>

## Modify\.Add\(this VoTTModel, string, Region\) Method

Adds a region to the specified asset within the VoTT model, creating the asset data if it does not already exist\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, string? assetId, DiGi.VoTT.Classes.Region? region);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.Region).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to modify\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.Region).assetId'></a>

`assetId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the asset associated with the region\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,DiGi.VoTT.Classes.Region).region'></a>

`region` [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region')

The [Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region') object to be added or updated\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the region was successfully added or updated; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,System.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string)'></a>

## Modify\.Add\(this VoTTModel, string, IEnumerable\<Point\>, string\) Method

Adds a new region to the VoTT model for a specific asset using a set of points and a tag name\.

```csharp
public static bool Add(this DiGi.VoTT.Classes.VoTTModel? voTTModel, string? assetId, System.Collections.Generic.IEnumerable<DiGi.VoTT.Classes.Point>? points, string? tagName);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,System.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to which the region will be added\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,System.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).assetId'></a>

`assetId` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The unique identifier of the asset associated with the region\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,System.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point') objects defining the boundary of the region\.

<a name='DiGi.VoTT.Modify.Add(thisDiGi.VoTT.Classes.VoTTModel,string,System.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_,string).tagName'></a>

`tagName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag to assign to the created region\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool') if the region was successfully added; otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/builtin\-types/bool')\.

<a name='DiGi.VoTT.Modify.Read(string)'></a>

## Modify\.Read\(string\) Method

Reads a [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') from the specified file path\.

```csharp
public static DiGi.VoTT.Classes.VoTTModel? Read(string? path);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Read(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path to the JSON file containing the model data\.

#### Returns
[VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')  
A [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance if the file is successfully read and deserialized; otherwise, null\.

<a name='DiGi.VoTT.Modify.Write(thisDiGi.VoTT.Classes.VoTTModel,string)'></a>

## Modify\.Write\(this VoTTModel, string\) Method

Writes the specified [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to a file in JSON format at the given path\.

```csharp
public static bool Write(this DiGi.VoTT.Classes.VoTTModel voTTModel, string path);
```
#### Parameters

<a name='DiGi.VoTT.Modify.Write(thisDiGi.VoTT.Classes.VoTTModel,string).voTTModel'></a>

`voTTModel` [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel')

The [VoTTModel](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.VoTTModel 'DiGi\.VoTT\.Classes\.VoTTModel') instance to be serialized and saved\.

<a name='DiGi.VoTT.Modify.Write(thisDiGi.VoTT.Classes.VoTTModel,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The destination file path where the JSON data will be written\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the model was successfully written to the file; otherwise, `false`\.

<a name='DiGi.VoTT.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.VoTT.Query.AssetState(thisDiGi.VoTT.Classes.Asset)'></a>

## Query\.AssetState\(this Asset\) Method

Gets the state of the specified asset as an [AssetState\(this Asset\)](DiGi.VoTT.md#DiGi.VoTT.Query.AssetState(thisDiGi.VoTT.Classes.Asset) 'DiGi\.VoTT\.Query\.AssetState\(this DiGi\.VoTT\.Classes\.Asset\)') value\.

```csharp
public static System.Nullable<DiGi.VoTT.Enums.AssetState> AssetState(this DiGi.VoTT.Classes.Asset asset);
```
#### Parameters

<a name='DiGi.VoTT.Query.AssetState(thisDiGi.VoTT.Classes.Asset).asset'></a>

`asset` [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')

The [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset') instance to retrieve the state from\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[AssetState](DiGi.VoTT.Enums.md#DiGi.VoTT.Enums.AssetState 'DiGi\.VoTT\.Enums\.AssetState')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The [AssetState\(this Asset\)](DiGi.VoTT.md#DiGi.VoTT.Query.AssetState(thisDiGi.VoTT.Classes.Asset) 'DiGi\.VoTT\.Query\.AssetState\(this DiGi\.VoTT\.Classes\.Asset\)') of the asset, or null if the asset is null\.

<a name='DiGi.VoTT.Query.AssetType(thisDiGi.VoTT.Classes.Asset)'></a>

## Query\.AssetType\(this Asset\) Method

Gets the asset type associated with the specified asset\.

```csharp
public static System.Nullable<DiGi.VoTT.Enums.AssetType> AssetType(this DiGi.VoTT.Classes.Asset asset);
```
#### Parameters

<a name='DiGi.VoTT.Query.AssetType(thisDiGi.VoTT.Classes.Asset).asset'></a>

`asset` [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')

The [Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset') instance to evaluate\.

#### Returns
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[AssetType](DiGi.VoTT.Enums.md#DiGi.VoTT.Enums.AssetType 'DiGi\.VoTT\.Enums\.AssetType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')  
The [AssetType\(this Asset\)](DiGi.VoTT.md#DiGi.VoTT.Query.AssetType(thisDiGi.VoTT.Classes.Asset) 'DiGi\.VoTT\.Query\.AssetType\(this DiGi\.VoTT\.Classes\.Asset\)') of the asset, or null if the asset is null\.

<a name='DiGi.VoTT.Query.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_)'></a>

## Query\.BoundingBox\(this IEnumerable\<Point\>\) Method

Calculates the bounding box for a given collection of points\.

```csharp
public static DiGi.VoTT.Classes.BoundingBox? BoundingBox(this System.Collections.Generic.IEnumerable<DiGi.VoTT.Classes.Point>? points);
```
#### Parameters

<a name='DiGi.VoTT.Query.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of [Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point') objects to evaluate\.

#### Returns
[BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')  
A [BoundingBox\(this IEnumerable&lt;Point&gt;\)](DiGi.VoTT.md#DiGi.VoTT.Query.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_) 'DiGi\.VoTT\.Query\.BoundingBox\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.VoTT\.Classes\.Point\>\)') representing the minimum and maximum coordinates, or `null` if the input is null or contains fewer than two points\.

<a name='DiGi.VoTT.Query.Hex(thisSystem.Drawing.Color)'></a>

## Query\.Hex\(this Color\) Method

Converts a [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') object to its hexadecimal string representation\.

```csharp
public static string Hex(this System.Drawing.Color color);
```
#### Parameters

<a name='DiGi.VoTT.Query.Hex(thisSystem.Drawing.Color).color'></a>

`color` [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color')

The [System\.Drawing\.Color](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color 'System\.Drawing\.Color') instance to convert\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A string representing the color in hexadecimal format \(e\.g\., "\#RRGGBB"\)\.

<a name='DiGi.VoTT.Query.Points(thisDiGi.VoTT.Classes.BoundingBox)'></a>

## Query\.Points\(this BoundingBox\) Method

Calculates the four corner points of the specified bounding box\.

```csharp
public static System.Collections.Generic.List<DiGi.VoTT.Classes.Point>? Points(this DiGi.VoTT.Classes.BoundingBox? boundingBox);
```
#### Parameters

<a name='DiGi.VoTT.Query.Points(thisDiGi.VoTT.Classes.BoundingBox).boundingBox'></a>

`boundingBox` [BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')

The [BoundingBox\(this IEnumerable&lt;Point&gt;\)](DiGi.VoTT.md#DiGi.VoTT.Query.BoundingBox(thisSystem.Collections.Generic.IEnumerable_DiGi.VoTT.Classes.Point_) 'DiGi\.VoTT\.Query\.BoundingBox\(this System\.Collections\.Generic\.IEnumerable\<DiGi\.VoTT\.Classes\.Point\>\)') instance to convert into a list of points\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the corners of the bounding box, or `null` if the provided bounding box is null\.