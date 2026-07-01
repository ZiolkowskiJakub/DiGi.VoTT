#### [DiGi\.VoTT](index.md 'index')

## DiGi\.VoTT\.Classes Namespace
### Classes

<a name='DiGi.VoTT.Classes.Asset'></a>

## Asset Class

Represents a digital asset and its associated metadata, including identification, location, and properties\.

```csharp
public class Asset
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Asset
### Properties

<a name='DiGi.VoTT.Classes.Asset.format'></a>

## Asset\.format Property

Gets or sets the format of the asset\.

```csharp
public string? format { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Asset.id'></a>

## Asset\.id Property

Gets or sets the unique identifier of the asset\.

```csharp
public string id { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Asset.name'></a>

## Asset\.name Property

Gets or sets the name of the asset\.

```csharp
public string? name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Asset.path'></a>

## Asset\.path Property

Gets or sets the path to the asset\.

```csharp
public string? path { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Asset.size'></a>

## Asset\.size Property

Gets or sets the size of the asset\.

```csharp
public DiGi.VoTT.Classes.Size? size { get; set; }
```

#### Property Value
[Size](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Size 'DiGi\.VoTT\.Classes\.Size')

<a name='DiGi.VoTT.Classes.Asset.state'></a>

## Asset\.state Property

Gets or sets the current state of the asset\.

```csharp
public short state { get; set; }
```

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.VoTT.Classes.Asset.type'></a>

## Asset\.type Property

Gets or sets the type of the asset\.

```csharp
public short type { get; set; }
```

#### Property Value
[System\.Int16](https://learn.microsoft.com/en-us/dotnet/api/system.int16 'System\.Int16')

<a name='DiGi.VoTT.Classes.AssetData'></a>

## AssetData Class

Represents the data associated with an asset, including its related regions and version information\.

```csharp
public class AssetData
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → AssetData
### Properties

<a name='DiGi.VoTT.Classes.AssetData.asset'></a>

## AssetData\.asset Property

Gets or sets the asset associated with the asset data\.

```csharp
public DiGi.VoTT.Classes.Asset? asset { get; set; }
```

#### Property Value
[Asset](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Asset 'DiGi\.VoTT\.Classes\.Asset')

<a name='DiGi.VoTT.Classes.AssetData.regions'></a>

## AssetData\.regions Property

Gets or sets the list of regions associated with the asset data\.

```csharp
public System.Collections.Generic.List<DiGi.VoTT.Classes.Region> regions { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Region](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Region 'DiGi\.VoTT\.Classes\.Region')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.VoTT.Classes.AssetData.version'></a>

## AssetData\.version Property

Gets or sets the version identifier for the asset data\.

```csharp
public string version { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.BoundingBox'></a>

## BoundingBox Class

Represents a rectangular bounding box defined by its position and dimensions\.

```csharp
public class BoundingBox
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → BoundingBox
### Properties

<a name='DiGi.VoTT.Classes.BoundingBox.height'></a>

## BoundingBox\.height Property

Gets or sets the height of the bounding box\.

```csharp
public float height { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.BoundingBox.left'></a>

## BoundingBox\.left Property

Gets or sets the left coordinate of the bounding box\.

```csharp
public float left { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.BoundingBox.top'></a>

## BoundingBox\.top Property

Gets or sets the top coordinate of the bounding box\.

```csharp
public float top { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.BoundingBox.width'></a>

## BoundingBox\.width Property

Gets or sets the width of the bounding box\.

```csharp
public float width { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.Point'></a>

## Point Class

Represents a point in two\-dimensional space with floating\-point coordinates\.

```csharp
public class Point
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Point
### Constructors

<a name='DiGi.VoTT.Classes.Point.Point(float,float)'></a>

## Point\(float, float\) Constructor

Initializes a new instance of the [Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point') class with the specified coordinates\.

```csharp
public Point(float x, float y);
```
#### Parameters

<a name='DiGi.VoTT.Classes.Point.Point(float,float).x'></a>

`x` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The X\-coordinate of the point\.

<a name='DiGi.VoTT.Classes.Point.Point(float,float).y'></a>

`y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The Y\-coordinate of the point\.
### Properties

<a name='DiGi.VoTT.Classes.Point.x'></a>

## Point\.x Property

Gets or sets the X\-coordinate of the point\.

```csharp
public float x { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.Point.y'></a>

## Point\.y Property

Gets or sets the Y\-coordinate of the point\.

```csharp
public float y { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.Region'></a>

## Region Class

Represents a spatial region defined by a type, boundary points, and an optional bounding box\.

```csharp
public class Region
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Region
### Properties

<a name='DiGi.VoTT.Classes.Region.boundingBox'></a>

## Region\.boundingBox Property

Gets or sets the bounding box that encompasses the region\.

```csharp
public DiGi.VoTT.Classes.BoundingBox? boundingBox { get; set; }
```

#### Property Value
[BoundingBox](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.BoundingBox 'DiGi\.VoTT\.Classes\.BoundingBox')

<a name='DiGi.VoTT.Classes.Region.id'></a>

## Region\.id Property

Gets or sets the unique identifier for the region\.

```csharp
public string id { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Region.points'></a>

## Region\.points Property

Gets or sets the list of [Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point') objects that define the boundaries of the region\.

```csharp
public System.Collections.Generic.List<DiGi.VoTT.Classes.Point> points { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Point](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Point 'DiGi\.VoTT\.Classes\.Point')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.VoTT.Classes.Region.tags'></a>

## Region\.tags Property

Gets or sets the list of tags associated with the region\.

```csharp
public System.Collections.Generic.List<string> tags { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.VoTT.Classes.Region.type'></a>

## Region\.type Property

Gets or sets the type of the region, such as a rectangle\.

```csharp
public string type { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Size'></a>

## Size Class

Represents the dimensions of an object, consisting of width and height values\.

```csharp
public class Size
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Size
### Constructors

<a name='DiGi.VoTT.Classes.Size.Size(float,float)'></a>

## Size\(float, float\) Constructor

Initializes a new instance of the [Size](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Size 'DiGi\.VoTT\.Classes\.Size') class with the specified width and height\.

```csharp
public Size(float width, float height);
```
#### Parameters

<a name='DiGi.VoTT.Classes.Size.Size(float,float).width'></a>

`width` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The width value to assign to the instance\.

<a name='DiGi.VoTT.Classes.Size.Size(float,float).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

The height value to assign to the instance\.
### Properties

<a name='DiGi.VoTT.Classes.Size.height'></a>

## Size\.height Property

Gets or sets the height value of the size\.

```csharp
public float height { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.Size.width'></a>

## Size\.width Property

Gets or sets the width value of the size\.

```csharp
public float width { get; set; }
```

#### Property Value
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

<a name='DiGi.VoTT.Classes.Tag'></a>

## Tag Class

Represents a tag used for categorization or labeling, containing a name and an optional associated color\.

```csharp
public class Tag
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Tag
### Constructors

<a name='DiGi.VoTT.Classes.Tag.Tag(string,string)'></a>

## Tag\(string, string\) Constructor

Initializes a new instance of the [Tag](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Tag 'DiGi\.VoTT\.Classes\.Tag') class\.

```csharp
public Tag(string name, string? color=null);
```
#### Parameters

<a name='DiGi.VoTT.Classes.Tag.Tag(string,string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the tag\.

<a name='DiGi.VoTT.Classes.Tag.Tag(string,string).color'></a>

`color` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional color associated with the tag\.
### Properties

<a name='DiGi.VoTT.Classes.Tag.color'></a>

## Tag\.color Property

Gets or sets the optional color associated with the tag\.

```csharp
public string? color { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.Tag.name'></a>

## Tag\.name Property

Gets or sets the name of the tag\.

```csharp
public string name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel'></a>

## VoTTModel Class

Represents a Voice\-over\-Text \(VoTT\) model containing configuration details, metadata, and associated assets\.

```csharp
public class VoTTModel
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → VoTTModel
### Properties

<a name='DiGi.VoTT.Classes.VoTTModel.assets'></a>

## VoTTModel\.assets Property

Gets or sets the dictionary of assets, where the key is a string identifier and the value is the associated [AssetData](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.AssetData 'DiGi\.VoTT\.Classes\.AssetData')\.

```csharp
public System.Collections.Generic.Dictionary<string,DiGi.VoTT.Classes.AssetData> assets { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[AssetData](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.AssetData 'DiGi\.VoTT\.Classes\.AssetData')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='DiGi.VoTT.Classes.VoTTModel.description'></a>

## VoTTModel\.description Property

Gets or sets the description of the VoTT model\.

```csharp
public string description { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel.format'></a>

## VoTTModel\.format Property

Gets or sets the format string of the VoTT model\.

```csharp
public string format { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel.id'></a>

## VoTTModel\.id Property

Gets or sets the unique identifier of the VoTT model\.

```csharp
public string id { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel.name'></a>

## VoTTModel\.name Property

Gets or sets the name of the VoTT model\.

```csharp
public string name { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel.securityToken'></a>

## VoTTModel\.securityToken Property

Gets or sets the security token associated with the VoTT model\.

```csharp
public string securityToken { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.VoTT.Classes.VoTTModel.tags'></a>

## VoTTModel\.tags Property

Gets or sets the list of [Tag](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Tag 'DiGi\.VoTT\.Classes\.Tag') objects associated with this model\.

```csharp
public System.Collections.Generic.List<DiGi.VoTT.Classes.Tag>? tags { get; set; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Tag](DiGi.VoTT.Classes.md#DiGi.VoTT.Classes.Tag 'DiGi\.VoTT\.Classes\.Tag')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.VoTT.Classes.VoTTModel.version'></a>

## VoTTModel\.version Property

Gets or sets the version string of the VoTT model\.

```csharp
public string version { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')