using DiGi.VoTT.Classes;
using System.Collections.Generic;

namespace DiGi.VoTT
{
    public static partial class Modify
    {
        /// <summary>Adds the specified asset to the VoTT model, creating a new entry or updating an existing one based on the asset's identifier.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to which the asset is added.</param>
        /// <param name="asset">The <see cref="Asset"/> to be added to the model.</param>
        /// <returns><c>true</c> if the asset was successfully added or updated; otherwise, <c>false</c>.</returns>
        public static bool Add(this VoTTModel? voTTModel, Asset? asset)
        {
            if (voTTModel == null || asset == null)
            {
                return false;
            }

            if (asset.id == null)
            {
                return false;
            }

            voTTModel.assets ??= [];

            if (!voTTModel.assets.TryGetValue(asset.id, out AssetData assetData) || assetData == null)
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

        /// <summary>Adds the specified asset data to the VoTT model and processes any associated region tags.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to which the asset is added.</param>
        /// <param name="assetData">The <see cref="AssetData"/> containing the asset information to be added.</param>
        /// <returns><c>true</c> if the asset was successfully added; otherwise, <c>false</c>.</returns>
        public static bool Add(this VoTTModel? voTTModel, AssetData? assetData)
        {
            if (voTTModel == null || assetData?.asset == null)
            {
                return false;
            }

            if (assetData.asset.id == null)
            {
                return false;
            }

            voTTModel.assets ??= [];

            voTTModel.assets[assetData.asset.id] = assetData;

            if (assetData.regions != null)
            {
                foreach (Region region in assetData.regions)
                {
                    if (region?.tags != null)
                    {
                        foreach (string tagName in region.tags)
                        {
                            Add(voTTModel, tagName);
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>Adds a region to the specified asset within the VoTT model, creating the asset data if it does not already exist.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to modify.</param>
        /// <param name="assetId">The unique identifier of the asset associated with the region.</param>
        /// <param name="region">The <see cref="Region"/> object to be added or updated.</param>
        /// <returns><see langword="true"/> if the region was successfully added or updated; otherwise, <see langword="false"/>.</returns>
        public static bool Add(this VoTTModel? voTTModel, string? assetId, Region? region)
        {
            if (voTTModel == null || assetId == null || region == null)
            {
                return false;
            }

            voTTModel.assets ??= [];

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

            assetData_Temp.regions ??= [];

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

        /// <summary>Adds a new region to the VoTT model for a specific asset using a bounding box and a tag name.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to which the region will be added.</param>
        /// <param name="assetId">The unique identifier of the asset associated with the region.</param>
        /// <param name="boundingBox">The <see cref="BoundingBox"/> defining the area of the region.</param>
        /// <param name="tagName">The name of the tag to assign to the created region.</param>
        /// <returns><see langword="true"/> if the region was successfully added; otherwise, <see langword="false"/>.</returns>
        public static bool Add(this VoTTModel? voTTModel, string? assetId, BoundingBox? boundingBox, string? tagName)
        {
            if (voTTModel == null || assetId == null || boundingBox == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region? region = Create.Region(boundingBox, tagName!);
            if (region == null)
            {
                return false;
            }

            return Add(voTTModel, assetId, region);
        }

        /// <summary>Adds a new region to the VoTT model for a specific asset using a set of points and a tag name.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to which the region will be added.</param>
        /// <param name="assetId">The unique identifier of the asset associated with the region.</param>
        /// <param name="points">The collection of <see cref="Point"/> objects defining the boundary of the region.</param>
        /// <param name="tagName">The name of the tag to assign to the created region.</param>
        /// <returns><see langword="true"/> if the region was successfully added; otherwise, <see langword="false"/>.</returns>
        public static bool Add(this VoTTModel? voTTModel, string? assetId, IEnumerable<Point>? points, string? tagName)
        {
            if (voTTModel == null || assetId == null || points == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            Region? region = Create.Region(points, tagName);
            if (region == null)
            {
                return false;
            }

            return Add(voTTModel, assetId, region);
        }

        /// <summary>Adds a tag with the specified name to the VoTT model if it does not already exist.</summary>
        /// <param name="voTTModel">The <see cref="VoTTModel"/> instance to which the tag will be added.</param>
        /// <param name="tagName">The name of the tag to add.</param>
        /// <returns><see langword="true"/> if the tag was successfully added or already existed; otherwise, <see langword="false"/>.</returns>
        public static bool Add(this VoTTModel? voTTModel, string? tagName)
        {
            if (voTTModel == null || string.IsNullOrWhiteSpace(tagName))
            {
                return false;
            }

            voTTModel.tags ??= [];

            if (voTTModel.tags.Find(x => x.name == tagName) == null)
            {
                Tag? tag = Create.Tag(tagName);
                if (tag == null)
                {
                    return false;
                }

                voTTModel.tags.Add(tag);
            }

            return true;
        }
    }
}
