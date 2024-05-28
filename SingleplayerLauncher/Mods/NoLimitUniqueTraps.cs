﻿using SingleplayerLauncher.Utils;

namespace SingleplayerLauncher.Mods
{
    public class NoLimitUniqueTraps : Mod
    {
        readonly private byte[] UNIQUE_BYTES_REFERENCE = { 0x37, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB6, 0xC4, 0x00, 0x00, 0x37, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xB7, 0xC4, 0x00, 0x00, 0x5F, 0xB0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1A, 0x11, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        readonly private int OFFSET_FROM_UNIQUE_BYTES = 0;

        private const int CHANGE_INDEX = 0x16157FE; // ( 5F B0 00 00 ): UseCountLimiter

        public override bool InstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideSingleByte(0, indexToModify);

            return true;
        }

        public override bool UninstallMod()
        {
            int bytesReferenceIndex = UPKFile.FindBytesKMP(UNIQUE_BYTES_REFERENCE, FileUtils.RoundToNearestLowerThousandPessimistic(CHANGE_INDEX));
            int indexToModify = bytesReferenceIndex + UNIQUE_BYTES_REFERENCE.Length + OFFSET_FROM_UNIQUE_BYTES;
            UPKFile.OverrideSingleByte(1, indexToModify);

            return true;
        }
    }
}