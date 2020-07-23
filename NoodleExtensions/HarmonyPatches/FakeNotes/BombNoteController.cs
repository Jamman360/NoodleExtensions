﻿namespace NoodleExtensions.HarmonyPatches
{
    using HarmonyLib;

    [NoodlePatch(typeof(BombNoteController))]
    [NoodlePatch("Init")]
    internal static class BombNoteControllerInit
    {
        [HarmonyPriority(Priority.High)]
#pragma warning disable SA1313
        private static void Postfix(NoteData noteData, CuttableBySaber cuttableBySaber)
#pragma warning restore SA1313
        {
            if (!FakeNoteHelper.GetCuttable(noteData))
            {
                cuttableBySaber.canBeCut = false;
            }
        }
    }
}
