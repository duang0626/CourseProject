﻿#pragma checksum "D:\1 学习资料\大二下\现代操作系统应用开发\UWP\期中项目\期中项目\Project\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6493C88919E171749871E17F218EDEA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace player
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class MainPage_obj34_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::player.Song.SongItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj35;

            public MainPage_obj34_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 35:
                        this.obj35 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::player.Song.SongItem data = args.NewValue as global::player.Song.SongItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::player.Song.SongItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::player.Song.SongItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::player.Song.SongItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // MainPage_obj34_Bindings

            public void SetDataRoot(global::player.Song.SongItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::player.Song.SongItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj35, obj, null);
                }
            }
        }

        private class MainPage_obj37_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::player.Song.SongItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj38;
            private global::Windows.UI.Xaml.Controls.Image obj39;

            private MainPage_obj37_BindingsTracking bindingsTracking;

            public MainPage_obj37_Bindings()
            {
                this.bindingsTracking = new MainPage_obj37_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 38:
                        this.obj38 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 39:
                        this.obj39 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::player.Song.SongItem data = args.NewValue as global::player.Song.SongItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::player.Song.SongItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::player.Song.SongItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::player.Song.SongItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj37_Bindings

            public void SetDataRoot(global::player.Song.SongItem newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::player.Song.SongItem obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Like(obj.Like, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj38, obj, null);
                }
            }
            private void Update_Like(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj39, (global::Windows.UI.Xaml.Media.ImageSource)this.LookupConverter("LikeConverter3").Convert(obj, typeof(global::Windows.UI.Xaml.Media.ImageSource), null, null), null);
                }
            }

            private class MainPage_obj37_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj37_Bindings> WeakRefToBindingObj; 

                public MainPage_obj37_BindingsTracking(MainPage_obj37_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj37_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj37_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::player.Song.SongItem obj = sender as global::player.Song.SongItem;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_Like(obj.Like, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Like":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Like(obj.Like, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::player.Song.SongItem obj)
                {
                    MainPage_obj37_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::player.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj33;
            private global::Windows.UI.Xaml.Controls.ListView obj36;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 33:
                        this.obj33 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 36:
                        this.obj36 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::player.MainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::player.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_searchlist(obj.searchlist, phase);
                        this.Update_list(obj.list, phase);
                    }
                }
            }
            private void Update_searchlist(global::player.List.ListItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_searchlist_getItems(obj.getItems, phase);
                    }
                }
            }
            private void Update_searchlist_getItems(global::System.Collections.ObjectModel.ObservableCollection<global::player.Song.SongItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj33, obj, null);
                }
            }
            private void Update_list(global::player.List.ListItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_list_getItems(obj.getItems, phase);
                    }
                }
            }
            private void Update_list_getItems(global::System.Collections.ObjectModel.ObservableCollection<global::player.Song.SongItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj36, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.SmallStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.BigStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 4:
                {
                    this.PoleStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 5:
                {
                    this.PoleBackStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 6:
                {
                    this.bottombar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.PrevButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 44 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PrevButton).Click += this.Prev_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.PlayPauseButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 45 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayPauseButton).Click += this.PlayPauseButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.NextButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 46 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.NextButton).Click += this.Next_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.TimeLine = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 11:
                {
                    this.VolumeLine = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 57 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.VolumeLine).ValueChanged += this.ChangeMediaVolume;
                    #line default
                }
                break;
            case 12:
                {
                    this.Playmode = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 59 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Playmode).Click += this.Playmode_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.Media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 63 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.Media).MediaOpened += this.Element_MediaOpened;
                    #line 63 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.Media).MediaEnded += this.Element_MediaEnded;
                    #line default
                }
                break;
            case 14:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 15:
                {
                    this.VisualStateMin0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 16:
                {
                    this.VisualStateMin800 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 17:
                {
                    this.topbar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 18:
                {
                    this.PlayList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 19:
                {
                    this.SearchOnlineList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 20:
                {
                    this.PlayingInterface = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 21:
                {
                    this.bigpic = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 22:
                {
                    this.smallpic = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 23:
                {
                    this.SongName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.SingerName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.AlbumName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.pole = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 27:
                {
                    this.album = (global::Windows.UI.Xaml.Media.ImageBrush)(target);
                }
                break;
            case 28:
                {
                    this.LikeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 261 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LikeButton).Click += this.LikeSong_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.ShareButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 262 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ShareButton).Click += this.share_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.LikeButtonImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 31:
                {
                    this.ShareImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 32:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element32 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 211 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element32).Click += this.ToPlayList_Click;
                    #line default
                }
                break;
            case 33:
                {
                    global::Windows.UI.Xaml.Controls.ListView element33 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 212 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)element33).ItemClick += this.SearchListListView_ItemClick;
                    #line default
                }
                break;
            case 36:
                {
                    this.PlayListListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 176 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.PlayListListView).ItemClick += this.PlayListListView_ItemClick;
                    #line default
                }
                break;
            case 40:
                {
                    this.selectPlayButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 170 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.selectPlayButton).Click += this.selectPlayButton_Click;
                    #line default
                }
                break;
            case 41:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element41 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 171 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element41).Click += this.DeleteSong_Click;
                    #line default
                }
                break;
            case 42:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element42 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 172 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element42).Click += this.ToRearchList_Click;
                    #line default
                }
                break;
            case 43:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element43 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 173 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element43).Click += this.OpenFile_Click;
                    #line default
                }
                break;
            case 44:
                {
                    this.GridTitleBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 45:
                {
                    this.FunctionBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 46:
                {
                    this.InputSearchBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 121 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.InputSearchBox).QuerySubmitted += this.searchOnline;
                    #line default
                }
                break;
            case 47:
                {
                    this.setting = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 48:
                {
                    this.About = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 129 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.About).Click += this.aboutClick;
                    #line default
                }
                break;
            case 49:
                {
                    this.ColorSelect = (global::Windows.UI.Xaml.Controls.MenuFlyoutSubItem)(target);
                }
                break;
            case 50:
                {
                    this.setYellow = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 131 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.setYellow).Click += this.yellowClick;
                    #line default
                }
                break;
            case 51:
                {
                    this.setBlue = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 132 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.setBlue).Click += this.blueClick;
                    #line default
                }
                break;
            case 52:
                {
                    this.setGreen = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 133 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.setGreen).Click += this.greenClick;
                    #line default
                }
                break;
            case 53:
                {
                    this.setPink = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 134 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.setPink).Click += this.pinkClick;
                    #line default
                }
                break;
            case 54:
                {
                    this.setRed = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 135 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)this.setRed).Click += this.redClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 34:
                {
                    global::Windows.UI.Xaml.Controls.Grid element34 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj34_Bindings bindings = new MainPage_obj34_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::player.Song.SongItem) element34.DataContext);
                    element34.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element34, bindings);
                }
                break;
            case 37:
                {
                    global::Windows.UI.Xaml.Controls.Grid element37 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj37_Bindings bindings = new MainPage_obj37_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::player.Song.SongItem) element37.DataContext);
                    bindings.SetConverterLookupRoot(this);
                    element37.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element37, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

