using DiGi.VoTT.Classes;
using System.Collections.Generic;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        public static bool Add(this VoTTModel voTTModel, Asset asset)
        {
            if (voTTModel == null || asset == null)
            {
                return false;
            }

            if (asset.id == null)
            {
                return false;
            }

            if (voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, AssetData>();
            }

            if(!voTTModel.assets.TryGetValue(asset.id, out AssetData assetData) || assetData == null)
            {
                voTTModel.assets[asset.id] = new AssetData()
                {
                    asset = asset,
                };
            }
            else
            {
                assetData.asset = asset;
            }

            return true;
        }
        
        public static bool Add(this VoTTModel voTTModel, AssetData assetData)
        {
            if(voTTModel == null || assetData?.asset == null)
            {
                return false;
            }

            if(assetData.asset.id == null)
            {
                return false;
            }

            if(voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, AssetData>();
            }

            voTTModel.assets[assetData.asset.id] = assetData;

            if(assetData.regions != null)
            {
                foreach(Region region in assetData.regions)
                {
                    if(region?.tags != null)
                    {
                        foreach(string tagName in region.tags)
                        {
                            Add(voTTModel, tagName);
                        }
                    }

                }
            }

            return true;
        }

        public static bool Add(this VoTTModel voTTModel, string assetId, Region region)
        {
            if (voTTModel == null || assetId == null || region == null)
            {
                return false;
            }

            if (voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, AssetData>();
            }

            if (!voTTModel.assets.TryGetValue(assetId, out AssetData assetData_Temp) || assetData_Temp == null)
            {
                assetData_Temp = new AssetData() 
                { 
                    asset = Create.Asset_ById(assetId) 
                };

                if (assetData_Temp == null)
                {
                    return false;
                }

                voTTModel.assets[assetId] = assetData_Temp;
            }

            if (assetData_Temp.regions == null)
            {
                assetData_Temp.regions = new List<Region>();
            }

            int index = assetData_Temp.regions.FindIndex(x => x.id == region.id);
            if (index == -1)
            {
                assetData_Temp.regions.Add(region);
            }
            else
            {
                assetData_Temp.regions[index] = region;
            }

            if (region.tags != null)
            {
                foreach (string tagName in region.tags)
                {
                    Add(voTTModel, tagName);
                }
            }

            return true;
        }

        public static bool Add(this VoTTModel voTTModel, string assetId, BoundingBox boundingBox, string tagName)
        {
            if (voTTModel == null || assetId == null || boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region region = Create.Region(boundingBox, tagName);
            if(region == null)
            {
                return false;
            }

            return Add(voTTModel, assetId, region);

        }

        public static bool Add(this VoTTModel voTTModel, string assetId, IEnumerable<Point> points, string tagName)
        {
            if (voTTModel == null || assetId == null || points == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region region = Create.Region(points, tagName);
            if (region == null)
            {
                return false;
            }

            return Add(voTTModel, assetId, region);
        }

        public static bool Add(this VoTTModel voTTModel, string tagName)
        {
            if(voTTModel == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            if(voTTModel.tags == null)
            {
                voTTModel.tags = new List<Tag>();
            }

            if(voTTModel.tags.Find(x => x.name == tagName) == null)
            {
                Tag tag = Create.Tag(tagName);
                if(tag == null)
                {
                    return false;
                }

                voTTModel.tags.Add(tag);
            }

            return true;
        }
    }
}

