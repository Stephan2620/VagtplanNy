﻿#pragma checksum "C:\Users\Mikkel\OneDrive\2 semprojekt - endelige projekt\VagtplanNy\view\AddVagtSide.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4B64056EFC08CD05ED71A48A4C39A30A"
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
    partial class AddVagtSide : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ComboBox_Text(global::Windows.UI.Xaml.Controls.ComboBox obj, global::System.String value, string targetNullValue)
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
            public static void Set_Windows_UI_Xaml_FrameworkElement_DataContext(global::Windows.UI.Xaml.FrameworkElement obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.DataContext = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AddVagtSide_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAddVagtSide_Bindings
        {
            private global::VagtplanNy.AddVagtSide dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj3;
            private global::Windows.UI.Xaml.Controls.ComboBox obj4;
            private global::Windows.UI.Xaml.Controls.ComboBox obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;
            private global::Windows.UI.Xaml.Controls.CalendarDatePicker obj9;
            private global::Windows.UI.Xaml.Controls.ListView obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj3TextDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5ItemsSourceDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7CommandDisabled = false;
            private static bool isobj8ItemsSourceDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9DataContextDisabled = false;
            private static bool isobj10ItemsSourceDisabled = false;

            private AddVagtSide_obj1_BindingsTracking bindingsTracking;

            public AddVagtSide_obj1_Bindings()
            {
                this.bindingsTracking = new AddVagtSide_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 14 && columnNumber == 83)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 14 && columnNumber == 137)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 38)
                {
                    isobj4ItemsSourceDisabled = true;
                }
                else if (lineNumber == 25 && columnNumber == 85)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 38)
                {
                    isobj5ItemsSourceDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 85)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 17)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 45 && columnNumber == 17)
                {
                    isobj7CommandDisabled = true;
                }
                else if (lineNumber == 47 && columnNumber == 32)
                {
                    isobj8ItemsSourceDisabled = true;
                }
                else if (lineNumber == 47 && columnNumber == 79)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 47)
                {
                    isobj9DataContextDisabled = true;
                }
                else if (lineNumber == 63 && columnNumber == 19)
                {
                    isobj10ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // view\AddVagtSide.xaml line 14
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 4: // view\AddVagtSide.xaml line 25
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 5: // view\AddVagtSide.xaml line 35
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 6: // view\AddVagtSide.xaml line 44
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 7: // view\AddVagtSide.xaml line 45
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // view\AddVagtSide.xaml line 47
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 9: // view\AddVagtSide.xaml line 60
                        this.obj9 = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)target;
                        break;
                    case 10: // view\AddVagtSide.xaml line 63
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ListView)target;
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

            // IAddVagtSide_Bindings

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
                    this.dataRoot = (global::VagtplanNy.AddVagtSide)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::VagtplanNy.AddVagtSide obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                        this.Update_ViewModel3(obj.ViewModel3, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel2(obj.ViewModel2, phase);
                    }
                }
            }
            private void Update_ViewModel(global::VagtplanNy.MedarbejderView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_OC_Medarbejder(obj.OC_Medarbejder, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_HentData(obj.HentData, phase);
                    }
                }
            }
            private void Update_ViewModel_OC_Medarbejder(global::System.Collections.ObjectModel.ObservableCollection<global::VagtplanNy.Medarbejder> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 14
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ViewModel3(global::VagtplanNy.ModelView.NyVagtView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel3_MedarbejderNavnVagt(obj.MedarbejderNavnVagt, phase);
                        this.Update_ViewModel3_VagtAfdeling(obj.VagtAfdeling, phase);
                        this.Update_ViewModel3_VagtLokation(obj.VagtLokation, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel3_AddNyVagt(obj.AddNyVagt, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel3_VagtTid(obj.VagtTid, phase);
                        this.Update_ViewModel3_VagtDato(obj.VagtDato, phase);
                        this.Update_ViewModel3_OC_NyVagt(obj.OC_NyVagt, phase);
                    }
                }
            }
            private void Update_ViewModel3_MedarbejderNavnVagt(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 14
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_ViewModel2(global::VagtplanNy.VagtView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel2_OC_Vagt(obj.OC_Vagt, phase);
                    }
                }
            }
            private void Update_ViewModel2_OC_Vagt(global::System.Collections.ObjectModel.ObservableCollection<global::VagtplanNy.Vagt> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 25
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
                    }
                    // view\AddVagtSide.xaml line 35
                    if (!isobj5ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                    }
                    // view\AddVagtSide.xaml line 47
                    if (!isobj8ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_VagtAfdeling(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 25
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_VagtLokation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 35
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_HentData(global::VagtplanNy.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\AddVagtSide.xaml line 44
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_AddNyVagt(global::VagtplanNy.RelayCommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // view\AddVagtSide.xaml line 45
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_VagtTid(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 47
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_VagtDato(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 60
                    if (!isobj9DataContextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_DataContext(this.obj9, obj, null);
                    }
                }
            }
            private void Update_ViewModel3_OC_NyVagt(global::System.Collections.ObjectModel.ObservableCollection<global::VagtplanNy.NyVagt> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // view\AddVagtSide.xaml line 63
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AddVagtSide_obj1_BindingsTracking
            {
                private global::System.WeakReference<AddVagtSide_obj1_Bindings> weakRefToBindingObj; 

                public AddVagtSide_obj1_BindingsTracking(AddVagtSide_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AddVagtSide_obj1_Bindings>(obj);
                }

                public AddVagtSide_obj1_Bindings TryGetBindingObject()
                {
                    AddVagtSide_obj1_Bindings bindingObject = null;
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
            case 2: // view\AddVagtSide.xaml line 13
                {
                    this.btn_GoBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 3: // view\AddVagtSide.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element3 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element3).SelectionChanged += this.ComboBox_SelectionChanged_3;
                }
                break;
            case 4: // view\AddVagtSide.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element4 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element4).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 5: // view\AddVagtSide.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element5 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element5).SelectionChanged += this.ComboBox_SelectionChanged_2;
                }
                break;
            case 6: // view\AddVagtSide.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Button_Click;
                }
                break;
            case 8: // view\AddVagtSide.xaml line 47
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element8 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element8).SelectionChanged += this.ComboBox_SelectionChanged_1;
                }
                break;
            case 9: // view\AddVagtSide.xaml line 60
                {
                    this.Kalender = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
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
            case 1: // view\AddVagtSide.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AddVagtSide_obj1_Bindings bindings = new AddVagtSide_obj1_Bindings();
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

