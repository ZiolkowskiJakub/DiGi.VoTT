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

            if(asset.asset == null)
            {
                return false;
            }

            if(voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, Asset>();
            }

            voTTModel.assets[asset.asset] = asset;

            if(asset.regions != null)
            {
                foreach(Region region in asset.regions)
                {
                    if(!string.IsNullOrWhiteSpace(region?.tagName))
                    {
                        continue;
                    }

                    if(voTTModel.tags == null)
                    {
                        voTTModel.tags = new List<string>();
                    }

                    if(!voTTModel.tags.Contains(region.tagName))
                    {
                        voTTModel.tags.Add(region.tagName);
                    }
                }
            }

            return true;
        }

        public static bool Add(this VoTTModel voTTModel, string asset, Region region)
        {
            if (voTTModel == null || asset == null || region == null)
            {
                return false;
            }

            if (voTTModel.assets == null)
            {
                voTTModel.assets = new Dictionary<string, Asset>();
            }

            if(!voTTModel.assets.TryGetValue(asset, out Asset asset_Temp) || asset_Temp == null)
            {
                asset_Temp = Create.Asset(asset);
                if(asset_Temp == null)
                {
                    return false;
                }

                voTTModel.assets[asset] = asset_Temp;
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

        public static bool Add(this VoTTModel voTTModel, string asset, BoundingBox boundingBox, string tagName)
        {
            if (voTTModel == null || asset == null || boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region region = Create.Region(boundingBox, tagName);
            if(region == null)
            {
                return false;
            }

            return Add(voTTModel, asset, region);

        }

        public static bool Add(this VoTTModel voTTModel, string asset, IEnumerable<Point> points, string tagName)
        {
            if (voTTModel == null || asset == null || points == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region region = Create.Region(points, tagName);
            if (region == null)
            {
                return false;
            }

            return Add(voTTModel, asset, region);
        }
    }
}

