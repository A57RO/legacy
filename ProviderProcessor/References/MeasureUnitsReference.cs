using System;

namespace ProviderProcessing.References
{
	public class MeasureUnitsReference
	{
		private static MeasureUnitsReference instance;

		public static MeasureUnitsReference GetInstance()
		{
			return instance ?? (instance = LoadReference());
		}

		public static MeasureUnitsReference LoadReference()
		{
			throw new NotImplementedException("������-������ ������������� �����������.");
		}

		public MeasureUnit FindByCode(string measureUnitCode)
		{
			throw new NotImplementedException("������ �� ������������");
		}

		// ������ ������
	}
}