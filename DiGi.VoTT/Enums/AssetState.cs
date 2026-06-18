namespace DiGi.VoTT.Enums
{
    /// <summary>Represents the current state of an asset within the system.</summary>
    public enum AssetState
    {
        /// <summary>Indicates that the asset has not been visited.</summary>
        NotVisited = 0,
        /// <summary>Indicates that the asset has been visited.</summary>
        Visited = 1,
        /// <summary>Indicates that the asset is in a tagged state.</summary>
        Tagged = 2,
    }
}
