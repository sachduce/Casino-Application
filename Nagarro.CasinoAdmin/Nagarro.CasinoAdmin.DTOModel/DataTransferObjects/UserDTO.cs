using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.CasinoAdmin.Shared;


namespace Nagarro.CasinoAdmin.DTOModel
{
    [EntityMapping("Nagarro.CasinoAdmin.EntityDataModel.EntityModel.UserDB", MappingType.TotalExplicit)]
    [ViewModelMapping("Nagarro.CasinoAdmin.Web.Shared.UserViewModel", MappingType.TotalExplicit)]
    public class UserDTO : DTOBase, IUserDTO
    {
        public UserDTO()
            : base(DTOType.UserDTO)
        {

        }
        [EntityPropertyMapping(MappingDirectionType.Both, "Id")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "Id")]
        public int Id { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "Name")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "Name")]
        public string Name { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "Contact")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "Contact")]
        public string Contact { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "DateOfBirth")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "DateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "Email")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "Email")]
        public string Email { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "CopyOfId")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "CopyOfId")]
        public string CopyOfId { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "AccountBalance")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "AccountBalance")]
        public int AccountBalance { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "BlockedAmount")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "BlockedAmount")]
        public int BlockedAmount { get; set; }
        [EntityPropertyMapping(MappingDirectionType.Both, "UniqueId")]
        [ViewModelPropertyMappingAttribute(MappingDirectionType.Both, "UniqueId")]
        public string UniqueId { get; set; }
    }
}
