namespace UnitOfWorkPattern.Api.AutoMapper
{
    using global::AutoMapper;

    public static class AutoMapperConfiguration
    {
        public static void Config()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile(new DtoEntityCommonMapper());
            });
        }
    }
}
