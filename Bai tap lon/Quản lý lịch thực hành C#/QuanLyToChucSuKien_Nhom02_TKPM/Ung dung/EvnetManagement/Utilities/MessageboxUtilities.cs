﻿using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace EventManager.Utilities
{
    public static class MsgboxUtil
    {
        public static DialogResult Error(Exception ex)
        {
            return XtraMessageBox.Show(ex.Message,
                                       "Events Managemet", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Error(string message)
        {
            return XtraMessageBox.Show("Lỗi: " + message, "Events Managemet",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Success(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Info(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesNo(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult OkCancel(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult Exclamation(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult YesNoCancel(string message)
        {
            return XtraMessageBox.Show(message, "Events Managemet",
                                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
        }

        public static void ShowTooltip(ToolTipController tooltip, string msg, string title)
        {
            var targ = new ToolTipControllerShowEventArgs
                           {
                               Title = title,
                               ToolTip = msg,
                               ShowBeak = true,
                               Rounded = true,
                               RoundRadius = 7,
                               ToolTipType = ToolTipType.SuperTip,
                               IconType = ToolTipIconType.Information,
                               IconSize = ToolTipIconSize.Small
                           };
            tooltip.ShowHint(targ);
        }
    }
}