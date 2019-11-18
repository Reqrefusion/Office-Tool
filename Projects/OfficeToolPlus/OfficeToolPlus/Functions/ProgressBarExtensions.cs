﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace OfficeTool.Functions
{
    public static class ProgressBarExtensions
    {
        /// <summary>
        /// 使用线性动画设置 Progress Bar 的值
        /// </summary>
        /// <param name="progressBar">Progress Bar</param>
        /// <param name="percentage">值</param>
        public static void SetPercent(this ProgressBar progressBar, double percentage)
        {
            DoubleAnimation animation = new DoubleAnimation(percentage, TimeSpan.FromMilliseconds(300))
            {
                AccelerationRatio = 0,
                DecelerationRatio = 0.6
            };
            progressBar.BeginAnimation(System.Windows.Controls.Primitives.RangeBase.ValueProperty, animation);
        }

        /// <summary>
        /// 使用线性动画设置 Progress Bar 的值
        /// </summary>
        /// <param name="progressBar">Progress Bar</param>
        /// <param name="percentage">值</param>
        /// <param name="percentage">持续时间</param>
        public static void SetPercent(this ProgressBar progressBar, double percentage, Duration duration)
        {
            DoubleAnimation animation = new DoubleAnimation(percentage, duration);
            animation.Completed += (obj, args) =>
            {
                progressBar.Value = percentage;
            };
            progressBar.BeginAnimation(System.Windows.Controls.Primitives.RangeBase.ValueProperty, animation);
        }
    }
}