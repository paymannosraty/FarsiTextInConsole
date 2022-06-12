using System.ComponentModel;

namespace TestFarsi.Infrastructure
{
    public enum Enums
    {
        /// <summary>
        /// If character be in first of word
        /// </summary>
        [Description("First position")]
        FirstPosition = 0,

        /// <summary>
        /// If character be in middle of word
        /// </summary>
        [Description("Middle position")]
        MiddlePosition = 1,

        /// <summary>
        /// If character be in end of word
        /// </summary>
        [Description("Last position")]
        LastPosition = 2,
    }
}
