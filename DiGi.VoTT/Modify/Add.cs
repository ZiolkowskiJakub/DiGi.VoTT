using DiGi.VoTT.Classes;
using System.Collections.Generic;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        public static bool Add(this VoTTModel voTTModel, Asset asset)
        {
            if(voTTModel == null || asset == null)
            {
                return false;
            }

            if(asset.id == null)
            {
                return false;
            }

            if(voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, Asset>();
            }

            voTTModel.assets[asset.id] = asset;

            if(asset.regions != null)
            {
                foreach(Region region in asset.regions)
                {
                    if(string.IsNullOrWhiteSpace(region?.tagName))
                    {
                        continue;
                    }

                    if(voTTModel.tags == null)
                    {
                        voTTModel.tags = new List<Tag>();
                    }

                    if(voTTModel.tags.Find(x => region.tagName == x?.name) == null)
                    {
                        voTTModel.tags.Add(Create.Tag(region.tagName));
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
                voTTModel.assets = new Dictionary<string, Asset>();
            }

            if(!voTTModel.assets.TryGetValue(assetId, out Asset asset_Temp) || asset_Temp == null)
            {
                asset_Temp = Create.Asset_ById(assetId);
                if(asset_Temp == null)
                {
                    return false;
                }

                voTTModel.assets[assetId] = asset_Temp;
            }

            if(asset_Temp.regions == null)
            {
               asset_Temp.regions = new List<Region>();
            }

            int index = asset_Temp.regions.FindIndex(x => x.id == region.id);
            if(index == -1)
            {
                asset_Temp.regions.Add(region);
            }
            else
            {
                asset_Temp.regions[index] = region;
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
    }
}

