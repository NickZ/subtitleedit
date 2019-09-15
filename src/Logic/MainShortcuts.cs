﻿using Nikse.SubtitleEdit.Core;
using System.Windows.Forms;

namespace Nikse.SubtitleEdit.Logic
{
    public class MainShortcuts
    {
        public Keys MainGeneralGoToFirstSelectedLine = Keys.None;
        public Keys MainGeneralGoToFirstEmptyLine = Keys.None;
        public Keys MainGeneralMergeSelectedLines = Keys.None;
        public Keys MainGeneralMergeSelectedLinesAndAutoBreak = Keys.None;
        public Keys MainGeneralMergeSelectedLinesAndUnbreak = Keys.None;
        public Keys MainGeneralMergeSelectedLinesAndUnbreakNoSpace = Keys.None;
        public Keys MainGeneralMergeSelectedLinesBilingual = Keys.None;
        public Keys MainGeneralMergeSelectedLinesOnlyFirstText = Keys.None;
        public Keys MainGeneralToggleTranslationMode = Keys.None;
        public Keys MainGeneralSwitchTranslationAndOriginal = Keys.None;
        public Keys MainGeneralMergeTranslationAndOriginal = Keys.None;
        public Keys MainGeneralMergeWithNext = Keys.None;
        public Keys MainGeneralMergeWithPrevious = Keys.None;
        public Keys MainGeneralGoToNextSubtitle = Keys.None;
        public Keys MainGeneralGoToPrevSubtitle = Keys.None;
        public Keys MainGeneralGoToStartOfCurrentSubtitle = Keys.None;
        public Keys MainGeneralGoToEndOfCurrentSubtitle = Keys.None;
        public Keys MainGeneralFileSaveAll = Keys.None;
        public Keys MainToolsAutoDuration = Keys.None;
        public Keys MainToolsBeamer = Keys.None;
        public Keys ToggleVideoDockUndock = Keys.None;
        public Keys VideoPause = Keys.None;
        public Keys VideoPlayPauseToggle = Keys.None;
        public Keys MainVideoPlayFromJustBefore = Keys.None;
        public Keys Video1FrameLeft = Keys.None;
        public Keys Video1FrameRight = Keys.None;
        public Keys Video1FrameLeftWithPlay = Keys.None;
        public Keys Video1FrameRightWithPlay = Keys.None;
        public Keys Video100MsLeft = Keys.None;
        public Keys Video100MsRight = Keys.None;
        public Keys Video500MsLeft = Keys.None;
        public Keys Video500MsRight = Keys.None;
        public Keys Video1000MsLeft = Keys.None;
        public Keys Video1000MsRight = Keys.None;
        public Keys Video5000MsLeft = Keys.None;
        public Keys Video5000MsRight = Keys.None;
        public Keys VideoGoToPrevSubtitle = Keys.None;
        public Keys VideoGoToNextSubtitle = Keys.None;
        public Keys VideoPlayFirstSelected = Keys.None;
        public Keys MainVideoFullscreen = Keys.None;
        public Keys MainVideoSlower = Keys.None;
        public Keys MainVideoFaster = Keys.None;
        public Keys MainVideoReset = Keys.None;
        public Keys MainGoToPreviousSubtitleAndFocusVideo = Keys.None;
        public Keys MainGoToNextSubtitleAndFocusVideo = Keys.None;
        public Keys MainAdjustExtendCurrentSubtitle = Keys.None;
        public Keys MainAutoCalcCurrentDuration = Keys.None;
        public Keys MainUnbreakNoSpace = Keys.None;
        public Keys MainGeneralToggleBookmarks = Keys.None;
        public Keys MainGeneralClearBookmarks = Keys.None;
        public Keys MainGeneralGoToBookmark = Keys.None;
        public Keys MainGeneralGoToPreviousBookmark = Keys.None;
        public Keys MainGeneralGoToNextBookmark = Keys.None;
        public Keys MainGeneralChooseProfile = Keys.None;
        public Keys MainTextBoxSplitAtCursor = Keys.None;
        public Keys MainTextBoxSplitAtCursorAndVideoPos = Keys.None;
        public Keys MainTextBoxSplitSelectedLineBilingual = Keys.None;
        public Keys MainTextBoxMoveLastWordDown = Keys.None;
        public Keys MainTextBoxMoveFirstWordFromNextUp = Keys.None;
        public Keys MainTextBoxMoveLastWordDownCurrent = Keys.None;
        public Keys MainTextBoxMoveFirstWordUpCurrent = Keys.None;
        public Keys MainTextBoxSelectionToLower = Keys.None;
        public Keys MainTextBoxSelectionToUpper = Keys.None;
        public Keys MainTextBoxToggleAutoDuration = Keys.None;
        public Keys MainCreateInsertSubAtVideoPos = Keys.None;
        public Keys MainCreateSetStart = Keys.None;
        public Keys MainCreateSetEnd = Keys.None;
        public Keys MainCreateStartDownEndUp = Keys.None;
        public Keys MainCreateSetEndAddNewAndGoToNew = Keys.None;
        public Keys MainAdjustSetStartAndOffsetTheRest = Keys.None;
        public Keys MainAdjustSetEndAndOffsetTheRest = Keys.None;
        public Keys MainAdjustSetEndAndOffsetTheRestAndGoToNext = Keys.None;
        public Keys MainAdjustSetEndAndGotoNext = Keys.None;
        public Keys MainAdjustInsertViaEndAutoStart = Keys.None;
        public Keys MainAdjustInsertViaEndAutoStartAndGoToNext = Keys.None;
        public Keys MainAdjustSetStartAutoDurationAndGoToNext = Keys.None;
        public Keys MainAdjustSetEndNextStartAndGoToNext = Keys.None;
        public Keys MainAdjustStartDownEndUpAndGoToNext = Keys.None;
        public Keys MainAdjustSetStartKeepDuration = Keys.None;
        public Keys MainAdjustSelected100MsForward = Keys.None;
        public Keys MainAdjustSelected100MsBack = Keys.None;
        public Keys MainAdjustAdjustStartXMsBack = Keys.None;
        public Keys MainAdjustAdjustStartXMsForward = Keys.None;
        public Keys MainAdjustAdjustEndXMsBack = Keys.None;
        public Keys MainAdjustAdjustEndXMsForward = Keys.None;
        public Keys MainInsertAfter = Keys.None;
        public Keys MainInsertBefore = Keys.None;
        public Keys MainTextBoxAutoBreak = Keys.None;
        public Keys MainTextBoxUnbreak = Keys.None;
        public Keys MainTextBoxBreakAtCursorPosition = Keys.None;
        public Keys MainTextBoxBreakAtCursorPositionAndGoToNext = Keys.None;
        public Keys MainMergeDialog = Keys.None;
        public Keys MainToggleFocus = Keys.None;
        public Keys MainListViewToggleDashes = Keys.None;
        public Keys MainListViewToggleMusicSymbols = Keys.None;
        public Keys MainListViewAutoDuration = Keys.None;
        public Keys MainListViewAlignmentN1 = Keys.None;
        public Keys MainListViewAlignmentN2 = Keys.None;
        public Keys MainListViewAlignmentN3 = Keys.None;
        public Keys MainListViewAlignmentN4 = Keys.None;
        public Keys MainListViewAlignmentN5 = Keys.None;
        public Keys MainListViewAlignmentN6 = Keys.None;
        public Keys MainListViewAlignmentN7 = Keys.None;
        public Keys MainListViewAlignmentN8 = Keys.None;
        public Keys MainListViewAlignmentN9 = Keys.None;
        public Keys MainListViewFocusWaveform = Keys.None;
        public Keys MainListViewGoToNextError = Keys.None;
        public Keys MainListViewCopyText = Keys.None;
        public Keys MainEditReverseStartAndEndingForRTL = Keys.None;
        public Keys WaveformVerticalZoom = Keys.None;
        public Keys WaveformVerticalZoomOut = Keys.None;
        public Keys WaveformZoomIn = Keys.None;
        public Keys WaveformZoomOut = Keys.None;
        public Keys WaveformSplit = Keys.None;
        public Keys WaveformPlaySelection = Keys.None;
        public Keys WaveformPlaySelectionEnd = Keys.None;
        public Keys WaveformSearchSilenceForward = Keys.None;
        public Keys WaveformSearchSilenceBack = Keys.None;
        public Keys WaveformAddTextAtHere = Keys.None;
        public Keys WaveformAddTextAtHereFromClipboard = Keys.None;
        public Keys WaveformFocusListView = Keys.None;
        public Keys WaveformGoToPreviousSceneChange = Keys.None;
        public Keys WaveformGoToNextSceneChange = Keys.None;
        public Keys WaveformToggleSceneChange = Keys.None;
        public Keys MainTranslateGoogleIt = Keys.None;
        public Keys MainTranslateGoogleTranslate = Keys.None;
        public Keys MainTranslateCustomSearch1 = Keys.None;
        public Keys MainTranslateCustomSearch2 = Keys.None;
        public Keys MainTranslateCustomSearch3 = Keys.None;
        public Keys MainTranslateCustomSearch4 = Keys.None;
        public Keys MainTranslateCustomSearch5 = Keys.None;

        public void SetShortcuts()
        {
            MainGeneralGoToFirstSelectedLine = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToFirstSelectedLine);
            MainGeneralGoToFirstEmptyLine = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToNextEmptyLine);
            MainGeneralMergeSelectedLines = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLines);
            MainGeneralMergeSelectedLinesAndAutoBreak = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLinesAndAutoBreak);
            MainGeneralMergeSelectedLinesAndUnbreak = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLinesAndUnbreak);
            MainGeneralMergeSelectedLinesAndUnbreakNoSpace = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLinesAndUnbreakCjk);
            MainGeneralMergeSelectedLinesBilingual = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLinesBilingual);
            MainGeneralMergeSelectedLinesOnlyFirstText = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeSelectedLinesOnlyFirstText);
            MainGeneralToggleTranslationMode = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralToggleTranslationMode);
            MainGeneralSwitchTranslationAndOriginal = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralSwitchOriginalAndTranslation);
            MainGeneralMergeTranslationAndOriginal = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeOriginalAndTranslation);
            MainGeneralMergeWithNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeWithNext);
            MainGeneralMergeWithPrevious = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralMergeWithPrevious);
            MainGeneralGoToNextSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToNextSubtitle);
            MainGeneralGoToPrevSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToPrevSubtitle);
            MainGeneralGoToStartOfCurrentSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToStartOfCurrentSubtitle);
            MainGeneralGoToEndOfCurrentSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToEndOfCurrentSubtitle);
            MainGeneralFileSaveAll = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainFileSaveAll);
            MainVideoPlayFromJustBefore = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoPlayFromJustBefore);
            VideoPause = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoPause);
            ToggleVideoDockUndock = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoToggleVideoControls);
            VideoPlayPauseToggle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoPlayPauseToggle);
            Video1FrameLeft = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1FrameLeft);
            Video1FrameRight = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1FrameRight);
            Video1FrameLeftWithPlay = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1FrameLeftWithPlay);
            Video1FrameRightWithPlay = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1FrameRightWithPlay);
            Video100MsLeft = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo100MsLeft);
            Video100MsRight = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo100MsRight);
            Video500MsLeft = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo500MsLeft);
            Video500MsRight = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo500MsRight);
            Video1000MsLeft = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1000MsLeft);
            Video1000MsRight = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo1000MsRight);
            Video5000MsLeft = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo5000MsLeft);
            Video5000MsRight = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideo5000MsRight);
            VideoGoToPrevSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoGoToPrevSubtitle);
            VideoGoToNextSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoGoToNextSubtitle);
            VideoPlayFirstSelected = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralPlayFirstSelected);
            MainGoToPreviousSubtitleAndFocusVideo = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToPreviousSubtitleAndFocusVideo);
            MainGoToNextSubtitleAndFocusVideo = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToNextSubtitleAndFocusVideo);
            MainAdjustExtendCurrentSubtitle = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralExtendCurrentSubtitle);
            MainAutoCalcCurrentDuration = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralAutoCalcCurrentDuration);
            MainUnbreakNoSpace = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralUnbrekNoSpace);
            MainGeneralToggleBookmarks = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralToggleBookmarks);
            MainGeneralClearBookmarks = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralClearBookmarks);
            MainGeneralGoToBookmark = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToBookmark);
            MainGeneralGoToPreviousBookmark = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToPreviousBookmark);
            MainGeneralGoToNextBookmark = UiUtil.GetKeys(Configuration.Settings.Shortcuts.GeneralGoToNextBookmark);
            MainGeneralChooseProfile = UiUtil.GetKeys(Configuration.Settings.Shortcuts.ChooseProfile);
            MainVideoFullscreen = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoFullscreen);
            MainVideoSlower = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoSlower);
            MainVideoFaster = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoFaster);
            MainVideoReset = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainVideoReset);
            MainToolsAutoDuration = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainToolsAutoDuration);
            MainToolsBeamer = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainToolsBeamer);
            MainListViewToggleDashes = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewToggleDashes);
            MainListViewToggleMusicSymbols = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewToggleMusicSymbols);
            MainListViewAutoDuration = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAutoDuration);
            MainListViewAlignmentN1 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN1);
            MainListViewAlignmentN2 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN2);
            MainListViewAlignmentN3 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN3);
            MainListViewAlignmentN4 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN4);
            MainListViewAlignmentN5 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN5);
            MainListViewAlignmentN6 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN6);
            MainListViewAlignmentN7 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN7);
            MainListViewAlignmentN8 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN8);
            MainListViewAlignmentN9 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewAlignmentN9);
            MainListViewFocusWaveform = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewFocusWaveform);
            MainListViewGoToNextError = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewGoToNextError);
            MainEditReverseStartAndEndingForRTL = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainEditReverseStartAndEndingForRTL);
            MainListViewCopyText = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainListViewCopyText);
            MainTextBoxSplitAtCursor = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxSplitAtCursor);
            MainTextBoxSplitAtCursorAndVideoPos = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxSplitAtCursorAndVideoPos);
            MainTextBoxSplitSelectedLineBilingual = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxSplitSelectedLineBilingual);
            MainTextBoxMoveLastWordDown = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxMoveLastWordDown);
            MainTextBoxMoveFirstWordFromNextUp = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxMoveFirstWordFromNextUp);
            MainTextBoxMoveLastWordDownCurrent = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxMoveLastWordDownCurrent);
            MainTextBoxMoveFirstWordUpCurrent = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxMoveFirstWordUpCurrent);
            MainTextBoxSelectionToLower = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxSelectionToLower);
            MainTextBoxSelectionToUpper = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxSelectionToUpper);
            MainTextBoxToggleAutoDuration = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxToggleAutoDuration);
            MainCreateInsertSubAtVideoPos = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainCreateInsertSubAtVideoPos);
            MainCreateSetStart = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainCreateSetStart);
            MainCreateSetEnd = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainCreateSetEnd);
            MainCreateStartDownEndUp = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainCreateStartDownEndUp);
            MainCreateSetEndAddNewAndGoToNew = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainCreateSetEndAddNewAndGoToNew);
            MainAdjustSetStartAndOffsetTheRest = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetStartAndOffsetTheRest);
            MainAdjustSetEndAndOffsetTheRest = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetEndAndOffsetTheRest);
            MainAdjustSetEndAndOffsetTheRestAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetEndAndOffsetTheRestAndGoToNext);
            MainAdjustSetEndAndGotoNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetEndAndGotoNext);
            MainAdjustInsertViaEndAutoStart = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustViaEndAutoStart);
            MainAdjustInsertViaEndAutoStartAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustViaEndAutoStartAndGoToNext);
            MainAdjustSetStartAutoDurationAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetStartAutoDurationAndGoToNext);
            MainAdjustSetEndNextStartAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetEndNextStartAndGoToNext);
            MainAdjustStartDownEndUpAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustStartDownEndUpAndGoToNext);
            MainAdjustSetStartKeepDuration = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSetStartKeepDuration);
            MainAdjustSelected100MsForward = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSelected100MsForward);
            MainAdjustSelected100MsBack = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustSelected100MsBack);
            MainAdjustAdjustStartXMsBack = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustStartXMsBack);
            MainAdjustAdjustStartXMsForward = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustStartXMsForward);
            MainAdjustAdjustEndXMsBack = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustEndXMsBack);
            MainAdjustAdjustEndXMsForward = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainAdjustEndXMsForward);
            MainInsertAfter = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainInsertAfter);
            MainInsertBefore = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainInsertBefore);
            MainTextBoxAutoBreak = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxAutoBreak);
            MainTextBoxBreakAtCursorPosition = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxBreakAtPosition);
            MainTextBoxBreakAtCursorPositionAndGoToNext = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxBreakAtPositionAndGoToNext);
            MainTextBoxUnbreak = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTextBoxUnbreak);
            MainMergeDialog = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainMergeDialog);
            MainToggleFocus = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainToggleFocus);
            WaveformVerticalZoom = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformVerticalZoom);
            WaveformVerticalZoomOut = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformVerticalZoomOut);
            WaveformZoomIn = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformZoomIn);
            WaveformZoomOut = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformZoomOut);
            WaveformSplit = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformSplit);
            WaveformPlaySelection = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformPlaySelection);
            WaveformPlaySelectionEnd = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformPlaySelectionEnd);
            WaveformSearchSilenceForward = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformSearchSilenceForward);
            WaveformSearchSilenceBack = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformSearchSilenceBack);
            WaveformAddTextAtHere = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformAddTextHere);
            WaveformAddTextAtHereFromClipboard = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformAddTextHereFromClipboard);
            WaveformFocusListView = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformFocusListView);
            WaveformGoToPreviousSceneChange = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformGoToPreviousSceneChange);
            WaveformGoToNextSceneChange = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformGoToNextSceneChange);
            WaveformToggleSceneChange = UiUtil.GetKeys(Configuration.Settings.Shortcuts.WaveformToggleSceneChange);
            MainTranslateGoogleIt = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateGoogleIt);
            MainTranslateGoogleTranslate = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateGoogleTranslate);
            MainTranslateCustomSearch1 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateCustomSearch1);
            MainTranslateCustomSearch2 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateCustomSearch2);
            MainTranslateCustomSearch3 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateCustomSearch3);
            MainTranslateCustomSearch4 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateCustomSearch4);
            MainTranslateCustomSearch5 = UiUtil.GetKeys(Configuration.Settings.Shortcuts.MainTranslateCustomSearch5);
        }
    }
}