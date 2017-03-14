using System;

namespace ProviderProcessing.Solved2
{
	public interface IProviderRepository
	{
		ProviderData FindByProviderId(Guid providerId);
		void RemoveById(Guid id);
		void Save(ProviderData data);
		void Update(ProviderData existingData);
	}

	public class ProviderRepository : IProviderRepository
	{
		public ProviderData FindByProviderId(Guid providerId)
		{
			throw new NotImplementedException("������ � ����� ������");
		}

		public void RemoveById(Guid id)
		{
			throw new NotImplementedException("������ � ����� ������");
		}

		public void Save(ProviderData data)
		{
			throw new NotImplementedException("������ � ����� ������");
		}

		public void Update(ProviderData existingData)
		{
			throw new NotImplementedException("������ � ����� ������");
		}
	}
}