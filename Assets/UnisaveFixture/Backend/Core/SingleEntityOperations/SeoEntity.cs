using Unisave.Entities;

namespace UnisaveFixture.Backend.Core.SingleEntityOperations
{
    public class SeoEntity : Entity
    {
        public string StringAttribute { get; set; }

        public SeoEnum EnumAttribute { get; set; } = SeoEnum.A;

        public enum SeoEnum
        {
            A = 1,
            B = 2,
            C = 3
        }
    }
}
