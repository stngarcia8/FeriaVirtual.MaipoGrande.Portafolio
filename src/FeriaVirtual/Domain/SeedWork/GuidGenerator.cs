using System;

namespace FeriaVirtual.Domain.SeedWork
{
    public static class GuidGenerator
    {

        public static Guid NewSequentialGuid()
        {
            byte[] uid = Guid.NewGuid().ToByteArray();
            byte[] secuentialGuid = new byte[uid.Length];
            byte[] binDate = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

            AsignFirstPartOfGuid(uid, secuentialGuid);
            AssignSecondPartOfGuid(secuentialGuid, binDate);

            return new Guid(secuentialGuid);
        }

        private static void AsignFirstPartOfGuid
            (byte[] uid, byte[] secuentialGuid)
        {
            for (int i = 0; i <= 6; i++)
                secuentialGuid[i] = uid[i];
            secuentialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));
        }

        private static void AssignSecondPartOfGuid
            (byte[] secuentialGuid, byte[] binDate)
        {
            int reverse = 15;
            secuentialGuid[9] = binDate[0];
            secuentialGuid[8] = binDate[1];
            for (int i = 2; i <= 7; i++)
            {
                secuentialGuid[reverse] = binDate[i];
                reverse -= 2;
            }
        }


    }
}
