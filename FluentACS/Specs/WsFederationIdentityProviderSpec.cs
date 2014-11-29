namespace FluentACS.Specs
{
	namespace FluentACS.Specs
	{
		public class WsFederationIdentityProviderSpec : IdentityProviderSpec
		{
			private string metadataUri;

			public WsFederationIdentityProviderSpec MetadataUri(string uri)
			{
				Guard.NotNullOrEmpty(() => uri, uri);

				this.metadataUri = uri;

				return this;
			}

			internal string MetadataUri()
			{
				return this.metadataUri;
			}
		}
	}
}
