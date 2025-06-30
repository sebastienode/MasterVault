namespace Keyforge.MasterVault.Web
{
    public static class MasterVaultHelper
    {
        public static MasterVaultParameters WithCards(this MasterVaultParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            parameters.Links.Add(MasterVaultParameters.LinkCards);
            return parameters;
        }

        public static MasterVaultParameters WithAccolades(this MasterVaultParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            parameters.Links.Add(MasterVaultParameters.LinkAccolades);
            return parameters;
        }

        public static MasterVaultParameters WithNotes(this MasterVaultParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            parameters.Links.Add(MasterVaultParameters.LinkNotes);
            return parameters;
        }
    }
}
