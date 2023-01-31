namespace DotnetApiBoilerplatev1._0.Model.Entities
{
    public class GroupAccounts : BaseEntity
    {
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
    }
}
