﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Xamarin.Forms.Button.ButtonContentLayout;

namespace Skor.Controls
{
    public class IconEntry:Entry
    {
        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(
       nameof(CornerRadius),
       typeof(double),
       typeof(IconEntry),
       4d);
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly BindableProperty FocusColorProperty = BindableProperty.Create(
        nameof(FocusColor),
        typeof(Color),
        typeof(IconEntry),
        Color.White);
        public Color FocusColor
        {
            get { return (Color)GetValue(FocusColorProperty); }
            set { SetValue(FocusColorProperty, value); }
        }
        public new static readonly BindableProperty BackgroundColorProperty = BindableProperty.Create(
      nameof(BackgroundColor),
      typeof(Color),
      typeof(IconEntry),
      Color.LightGray);
        public new Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }
        public static readonly BindableProperty DisabledColorProperty = BindableProperty.Create(
       nameof(DisabledColor),
       typeof(Color),
       typeof(IconEntry),
       Color.WhiteSmoke);
        public Color DisabledColor
        {
            get { return (Color)GetValue(DisabledColorProperty); }
            set { SetValue(DisabledColorProperty, value); }
        }
        public static readonly BindableProperty IconProperty = BindableProperty.Create(
        nameof(Icon),
        typeof(FileImageSource),
        typeof(IconEntry),
        default(FileImageSource));
        public FileImageSource Icon
        {
            get { return (FileImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly BindableProperty IconPositionProperty = BindableProperty.Create(
        nameof(IconPosition),
        typeof(ImagePosition),
        typeof(IconEntry),
        ImagePosition.Left);
        public ImagePosition IconPosition
        {
            get { return (ImagePosition)GetValue(IconPositionProperty); }
            set { SetValue(IconPositionProperty, value); }
        }
    }
}
