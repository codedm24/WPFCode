using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SixthPage : Page
    {
        public SixthPage()
        {
            this.InitializeComponent();
            inkCanvas.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch | CoreInputDeviceTypes.Pen;
            ColorSelection1 = new ColorSelection(inkCanvas);
        }

        public ColorSelection ColorSelection1 { get; }

        private const string FileTypeExtension = ".strokes";

        private void OnDeferLoad(object sender, RoutedEventArgs e)
        {
            FindName(nameof(deferGrid));
        }

        public async void OnSave()
        {
            var picker = new FileSavePicker
            {
                SuggestedStartLocation = PickerLocationId.PicturesLibrary,
                DefaultFileExtension = FileTypeExtension,
                SuggestedFileName = "sample"
            };
            picker.FileTypeChoices.Add("Stroke File", new List<string>() { FileTypeExtension });
            StorageFile file = await picker.PickSaveFileAsync();
            if (file != null)
            {
                using (StorageStreamTransaction tx = await file.OpenTransactedWriteAsync())
                {
                    await inkCanvas.InkPresenter.StrokeContainer.SaveAsync(tx.Stream);
                    await tx.CommitAsync();
                }
            }
        }

        public async void OnLoad()
        {
            var picker = new FileOpenPicker
            {
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };
            picker.FileTypeFilter.Add(FileTypeExtension);

            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                using (var stream = await file.OpenReadAsync())
                {
                    await inkCanvas.InkPresenter.StrokeContainer.LoadAsync(stream);
                }
            }
        }

        public void OnClear()
        {
            inkCanvas.InkPresenter.StrokeContainer.Clear();
        }

        private void AppBarButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SeventhPage));
        }
    }

    public class ColorSelection : BindableBase
    {
        public ColorSelection(InkCanvas inkCanvas)
        {
            _inkCanvas = inkCanvas;
            Red = false;
            Green = false;
            Blue = false;
        }
        private InkCanvas _inkCanvas;

        private bool? _red;
        public bool? Red
        {
            get { return _red; }
            set { SetColor(ref _red, value); }
        }
        private bool? _green;
        public bool? Green
        {
            get { return _green; }
            set { SetColor(ref _green, value); }
        }
        private bool? _blue;
        public bool? Blue
        {
            get { return _blue; }
            set { SetColor(ref _blue, value); }
        }

        public void SetColor(ref bool? item, bool? value)
        {
            SetProperty(ref item, value);

            InkDrawingAttributes defaultAttributes = _inkCanvas.InkPresenter.CopyDefaultDrawingAttributes();
            defaultAttributes.PenTip = PenTipShape.Rectangle;
            defaultAttributes.Size = new Size(3, 3);

            defaultAttributes.Color = new Windows.UI.Color()
            {
                A = 255,
                R = Red == true ? (byte)0xff : (byte)0,
                G = Green == true ? (byte)0xff : (byte)0,
                B = Blue == true ? (byte)0xff : (byte)0
            };
            _inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(defaultAttributes);
        }
    }

    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(item, value)) return false;
            item = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
