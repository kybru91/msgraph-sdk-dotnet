using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Movies rating labels in France</summary>
    public enum RatingFranceMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The 10 classification prohibits the screening of the film to minors under 10</summary>
        [EnumMember(Value = "agesAbove10")]
        AgesAbove10,
        /// <summary>The 12 classification prohibits the screening of the film to minors under 12</summary>
        [EnumMember(Value = "agesAbove12")]
        AgesAbove12,
        /// <summary>The 16 classification prohibits the screening of the film to minors under 16</summary>
        [EnumMember(Value = "agesAbove16")]
        AgesAbove16,
        /// <summary>The 18 classification prohibits the screening to minors under 18</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
    }
}
