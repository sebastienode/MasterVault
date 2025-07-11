using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyforge.MasterVault.Entity
{
    public static class Expansion
    {
        private static readonly Dictionary<int, string> _expansionNames = new()
        {
            { 341, "Call of the Archons" },
            { 435, "Age of Ascension" },
            { 452, "Worlds Collide" },
            { 479, "Mass Mutation" },
            { 496, "Dark Tidings" },
            { 600, "Winds of Exchange" },
            { 601, "Unchained 2023" },
            { 609, "Vault Masters 2023" },
            { 700, "Grim Reminders" },
            { 722, "Menagerie 2024" },
            { 737, "Vault Masters 2024" },
            { 800, "Æmber Skies" },
            { 855, "Token Of Changes" },
            { 874, "More Mutation" },
            { 886, "Prophetic Visions" },
            { 892, "Martian Civil Wars" },
            { 907, "Discovery" },
            { 918, "Crucible Clash" },
            { 928, "Draconian Measures" },
            { 939, "Vault Masters 2025" },
        };

        public static string GetExpansionName(int expansionId)
        {
            if (_expansionNames.TryGetValue(expansionId, out var name))
            {
                return name;
            }
            throw new UnknownExpansionException(expansionId);
        }
    }

    public class UnknownExpansionException : Exception
    {
        public UnknownExpansionException(int expansionId)
            : base($"Unknown expansion ID: {expansionId}. Please check the expansion ID or update the expansion list.")
        { }
    }
}
