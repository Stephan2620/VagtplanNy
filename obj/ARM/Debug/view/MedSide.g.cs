﻿#pragma checksum "C:\Users\Mikkel\OneDrive\2 semprojekt - endelige projekt\VagtplanNy\view\MedSide.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3CB0B771BF8C50E9A0FFCA2DAF0D1861"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VagtplanNy
{
    partial class MedSide : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MedSide_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMedSide_Bindings
        {
            private global::VagtplanNy.MedSide dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBox obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.Button obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2SelectedItemDisabled = false;
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7CommandDisabled = false;
            private static bool isobj8CommandDisabled = false;

            private MedSide_obj1_BindingsTracking bindingsTracking;

            public MedSide_obj1_Bindings()
            {
                this.bindingsTracking = new MedSide_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 16 && columnNumber == 19)
                {
                    isobj2SelectedItemDisabled = true;
                }
                else if (lineNumber == 16 && columnNumber == 86)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 36 && columnNumber == 85)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 88)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 38 && columnNumber == 17)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 17)
                {
                    isobj7CommandDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 17)
                {
                    isobj8CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // view\MedSide.xaml line 16
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 4: // view\MedSide.xaml line 36
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // view\MedSide.xaml line 37
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // view\MedSide.xaml line 38
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 7: // view\MedSide.xaml line 39
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // view\MedSide.xaml line 40
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMedSide_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::VagtplanNy.MedSide)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::VagtplanNy.MedSide obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::VagtplanNy.MedarbejderView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedMedarbejder(obj.SelectedMedarbejder, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_OC_Medarbejder(obj.OC_Medarbejder, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_MedNavn(obj.MedNavn, phase);
                        this.Update_ViewModel_MedTelefon(obj.MedTelefon, phase);
                        this.Update_ViewModel_AddNyMedarbejder(obj.AddNyMedarbejder, phase);
                        this.Update_ViewModel_HentData(obj.HentData, phase);
                        this.Update_ViewModel_SletSelectedMedarbejder(obj.SletSelectedMedarbejder, phase);
                    }
                }
            }
            private void Update_ViewModel_SelectedMedarbejder(global::VagtplanNy.Medarbejder obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_SelectedMedarbejder(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 16
                    if (!isobj2SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_OC_Medarbejder(global::System.Collections.ObjectModel.ObservableCollection<global::VagtplanNy.Medarbejder> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\MedSide.xaml line 16
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MedNavn(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 36
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MedTelefon(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 37
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_AddNyMedarbejder(global::VagtplanNy.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 38
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ViewModel_HentData(global::VagtplanNy.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 39
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel_SletSelectedMedarbejder(global::VagtplanNy.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\MedSide.xaml line 40
                    if (!isobj8CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj8, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_2_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.SelectedMedarbejder = (global::VagtplanNy.Medarbejder)this.obj2.SelectedItem;
                        }
                    }
                }
            }
            private void UpdateTwoWay_4_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.MedNavn = this.obj4.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_5_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.MedTelefon = this.obj5.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MedSide_obj1_BindingsTracking
            {
                private global::System.WeakReference<MedSide_obj1_Bindings> weakRefToBindingObj; 

                public MedSide_obj1_BindingsTracking(MedSide_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MedSide_obj1_Bindings>(obj);
                }

                public MedSide_obj1_Bindings TryGetBindingObject()
                {
                    MedSide_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel_SelectedMedarbejder(null);
                }

                public void PropertyChanged_ViewModel_SelectedMedarbejder(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MedSide_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::VagtplanNy.Medarbejder obj = sender as global::VagtplanNy.Medarbejder;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::VagtplanNy.Medarbejder cache_ViewModel_SelectedMedarbejder = null;
                public void UpdateChildListeners_ViewModel_SelectedMedarbejder(global::VagtplanNy.Medarbejder obj)
                {
                    if (obj != cache_ViewModel_SelectedMedarbejder)
                    {
                        if (cache_ViewModel_SelectedMedarbejder != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_SelectedMedarbejder).PropertyChanged -= PropertyChanged_ViewModel_SelectedMedarbejder;
                            cache_ViewModel_SelectedMedarbejder = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_SelectedMedarbejder = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_SelectedMedarbejder;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.ListView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_SelectedItem();
                        }
                    });
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3: // view\MedSide.xaml line 34
                {
                    this.btn_GoBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // view\MedSide.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MedSide_obj1_Bindings bindings = new MedSide_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

