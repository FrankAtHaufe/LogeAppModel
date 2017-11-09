//----------------------------------------------------------------------------------------------------
// <auto-generated>
//
//		This code was automatically generated by the LeanFT Application Model code generator.
//
//		Changes to this file may cause incorrect behavior and will be lost 
//		when the code is regenerated.
//
// </auto-generated>
//----------------------------------------------------------------------------------------------------
using System;
using HP.LFT.SDK;  
using System.Collections.Generic;

namespace LogeAppModel
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("This class is automatically generated by the LeanFT Application Model code generator.", "14.00")]
	public class ClassStandardDialog : AppModelBase
	{
		#region Constructors

		public ClassStandardDialog()
		{
			Name = @"ClassStandardDialog";
			StandardDialog = new StandardDialogNode(this);
			RebuildDescriptions();
			
		}

		public ClassStandardDialog(ITestObject contextTestObject)
		{
			Name = @"ClassStandardDialog";
			StandardDialog = new StandardDialogNode(contextTestObject, this);
			RebuildDescriptions();
			
		}

		#endregion

		#region Test Objects
	
		public StandardDialogNode StandardDialog { get; private set; }
	
		#endregion
	
		#region Inner Classes
	
		public sealed class StandardDialogNode : DialogNodeBase
		{
			#region Constructors
		
			public StandardDialogNode(AppModelBase applicationModel) : base(applicationModel)
			{
				Button = new ButtonNode(this, applicationModel);
				DisplayName = @"StandardDialog";
			}
		
			public StandardDialogNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
			{
				Button = new ButtonNode(this, applicationModel);
				DisplayName = @"StandardDialog";
			}
		
			#endregion
		
			#region Description
		
			protected override HP.LFT.SDK.StdWin.DialogDescription CreateDescription()
			{
				return new HP.LFT.SDK.StdWin.DialogDescription
				{
					Text = As.RegExp(@"Firmenassistent|Firmen.*|Lexware.*|Loge.*"),
					NativeClass = @"#32770"
				};
			}
		
			#endregion
		
			#region Test Objects
		
			public ButtonNode Button { get; private set; }
		
			#endregion
		
			#region Inner Classes
		
			public sealed class ButtonNode : ButtonNodeBase
			{
				#region Constructors
			
				public ButtonNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"Button";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.StdWin.ButtonDescription CreateDescription()
				{
					return new HP.LFT.SDK.StdWin.ButtonDescription
					{
						Text = @"OK",
						NativeClass = @"Button"
					};
				}
			
				#endregion
			
			}

			#endregion
		}

		#endregion

		#region Base Classes

		public abstract class ButtonNodeBase : AppModelNodeBase<HP.LFT.SDK.StdWin.IButton, HP.LFT.SDK.StdWin.ButtonDescription>, HP.LFT.SDK.StdWin.IButton
		{
			public ButtonNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void MouseMove(HP.LFT.SDK.Location moveTo)
			{
				 Concrete.MouseMove(moveTo);
			}
	
			public void Click(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.Click(button);
			}
	
			public void Click(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.Click(args);
			}
	
			public void DoubleClick(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.DoubleClick(button);
			}
	
			public void DoubleClick(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.DoubleClick(args);
			}
	
			public void SendKeys(string input, HP.LFT.SDK.KeyModifier modifiers)
			{
				 Concrete.SendKeys(input, modifiers);
			}
	
			public void SendKeys(string input)
			{
				 Concrete.SendKeys(input);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget)
			{
				 Concrete.DragAndDropOn(dropTarget);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget, HP.LFT.SDK.DragAndDropArgs dragAndDropArgs)
			{
				 Concrete.DragAndDropOn(dropTarget, dragAndDropArgs);
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			#endregion
	
			#region Public Properties
	
			public bool IsRightAligned
			{
				get { return Concrete.IsRightAligned; }		
			}
	
			public bool IsRightToLeftLayout
			{
				get { return Concrete.IsRightToLeftLayout; }		
			}
	
			public bool IsRightToLeftReading
			{
				get { return Concrete.IsRightToLeftReading; }		
			}
	
			public string AccessibleName
			{
				get { return Concrete.AccessibleName; }		
			}
	
			public string AttachedText
			{
				get { return Concrete.AttachedText; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public HP.LFT.SDK.WindowExtendedStyles WindowExtendedStyle
			{
				get { return Concrete.WindowExtendedStyle; }		
			}
	
			public HP.LFT.SDK.WindowStyles WindowStyle
			{
				get { return Concrete.WindowStyle; }		
			}
	
			public string WindowClassRegExp
			{
				get { return Concrete.WindowClassRegExp; }		
			}
	
			public int WindowId
			{
				get { return Concrete.WindowId; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string WindowTitleRegExp
			{
				get { return Concrete.WindowTitleRegExp; }		
			}
	
			public bool IsVisible
			{
				get { return Concrete.IsVisible; }		
			}
	
			public System.IntPtr Handle
			{
				get { return Concrete.Handle; }		
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public System.Drawing.Point AbsoluteLocation
			{
				get { return Concrete.AbsoluteLocation; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			#endregion
		}

		public abstract class DialogNodeBase : TopLevelObjectNodeBase<HP.LFT.SDK.StdWin.IDialog, HP.LFT.SDK.StdWin.DialogDescription>, HP.LFT.SDK.StdWin.IDialog
		{
			public DialogNodeBase(AppModelBase applicationModel) : base(applicationModel) { }
	
			public DialogNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void Activate()
			{
				 Concrete.Activate();
			}
	
			public void Activate(HP.LFT.SDK.MouseButton button)
			{
				 Concrete.Activate(button);
			}
	
			public void Close()
			{
				 Concrete.Close();
			}
	
			public void Maximize()
			{
				 Concrete.Maximize();
			}
	
			public void Minimize()
			{
				 Concrete.Minimize();
			}
	
			public void Move(System.Drawing.Point point)
			{
				 Concrete.Move(point);
			}
	
			public void Move(int x, int y)
			{
				 Concrete.Move(x, y);
			}
	
			public void Resize(System.Drawing.Size size)
			{
				 Concrete.Resize(size);
			}
	
			public void Resize(int width, int height)
			{
				 Concrete.Resize(width, height);
			}
	
			public void Restore()
			{
				 Concrete.Restore();
			}
	
			public void MouseMove(HP.LFT.SDK.Location moveTo)
			{
				 Concrete.MouseMove(moveTo);
			}
	
			public void Click(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.Click(button);
			}
	
			public void Click(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.Click(args);
			}
	
			public void DoubleClick(HP.LFT.SDK.MouseButton button = HP.LFT.SDK.MouseButton.Left)
			{
				 Concrete.DoubleClick(button);
			}
	
			public void DoubleClick(HP.LFT.SDK.ClickArgs args)
			{
				 Concrete.DoubleClick(args);
			}
	
			public void SendKeys(string input, HP.LFT.SDK.KeyModifier modifiers)
			{
				 Concrete.SendKeys(input, modifiers);
			}
	
			public void SendKeys(string input)
			{
				 Concrete.SendKeys(input);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget)
			{
				 Concrete.DragAndDropOn(dropTarget);
			}
	
			public void DragAndDropOn(HP.LFT.SDK.ISupportDragAndDrop dropTarget, HP.LFT.SDK.DragAndDropArgs dragAndDropArgs)
			{
				 Concrete.DragAndDropOn(dropTarget, dragAndDropArgs);
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			#endregion
	
			#region Public Properties
	
			public bool IsActive
			{
				get { return Concrete.IsActive; }		
			}
	
			public bool HasBorder
			{
				get { return Concrete.HasBorder; }		
			}
	
			public bool HasCaption
			{
				get { return Concrete.HasCaption; }		
			}
	
			public bool HasSizebox
			{
				get { return Concrete.HasSizebox; }		
			}
	
			public bool HasSystemMenu
			{
				get { return Concrete.HasSystemMenu; }		
			}
	
			public bool IsOwnedWindow
			{
				get { return Concrete.IsOwnedWindow; }		
			}
	
			public bool IsChildWindow
			{
				get { return Concrete.IsChildWindow; }		
			}
	
			public bool IsMdiChildWindow
			{
				get { return Concrete.IsMdiChildWindow; }		
			}
	
			public bool IsPopupWindow
			{
				get { return Concrete.IsPopupWindow; }		
			}
	
			public bool IsToolWindow
			{
				get { return Concrete.IsToolWindow; }		
			}
	
			public bool IsMaximizable
			{
				get { return Concrete.IsMaximizable; }		
			}
	
			public bool IsMinimizable
			{
				get { return Concrete.IsMinimizable; }		
			}
	
			public HP.LFT.SDK.WindowState WindowState
			{
				get { return Concrete.WindowState; }		
			}
	
			public bool IsTopmost
			{
				get { return Concrete.IsTopmost; }		
			}
	
			public bool IsRightAligned
			{
				get { return Concrete.IsRightAligned; }		
			}
	
			public bool IsRightToLeftLayout
			{
				get { return Concrete.IsRightToLeftLayout; }		
			}
	
			public bool IsRightToLeftReading
			{
				get { return Concrete.IsRightToLeftReading; }		
			}
	
			public string AccessibleName
			{
				get { return Concrete.AccessibleName; }		
			}
	
			public string AttachedText
			{
				get { return Concrete.AttachedText; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public HP.LFT.SDK.WindowExtendedStyles WindowExtendedStyle
			{
				get { return Concrete.WindowExtendedStyle; }		
			}
	
			public HP.LFT.SDK.WindowStyles WindowStyle
			{
				get { return Concrete.WindowStyle; }		
			}
	
			public string WindowClassRegExp
			{
				get { return Concrete.WindowClassRegExp; }		
			}
	
			public int WindowId
			{
				get { return Concrete.WindowId; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string WindowTitleRegExp
			{
				get { return Concrete.WindowTitleRegExp; }		
			}
	
			public bool IsVisible
			{
				get { return Concrete.IsVisible; }		
			}
	
			public System.IntPtr Handle
			{
				get { return Concrete.Handle; }		
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public System.Drawing.Point AbsoluteLocation
			{
				get { return Concrete.AbsoluteLocation; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			#endregion
		}

		#endregion
	}
}