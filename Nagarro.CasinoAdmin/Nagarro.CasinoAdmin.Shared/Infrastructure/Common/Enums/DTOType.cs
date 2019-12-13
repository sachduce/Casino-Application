namespace Nagarro.CasinoAdmin.Shared
{
    /// <summary>
    /// Data Transfer Objects
    /// </summary>
    public enum DTOType
    {

        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,
        [QualifiedTypeName("Nagarro.CasinoAdmin.DTOModel.dll", "Nagarro.CasinoAdmin.DTOModel.UserDTO")]
        UserDTO = 1
    }
}
