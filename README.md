# RazorBasePageSample

Following the [discussion](https://github.com/aspnet/Mvc/issues/6769) I've tried to make my base page working.

**MyBasePage**
```
public abstract class MyBasePage : Page
{
    public void SetTitle(string message)
    {
        this.PageContext.ViewData["title"] = message;
    }
}
```

**_ViewImports.cshtml**
```
@inherits MyBasePage
@using RazorBasePageSample
@namespace RazorBasePageSample.Pages
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

**Index.cshtml**
```
@page
@model IndexModel
@{    
    SetTitle("Home page");
}
```

**But it does not work! It just throws the exception:**
```
System.ArgumentException: Property 'ViewData' is of type 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1[[RazorBasePageSample.Pages.IndexModel, RazorBasePageSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]', but this method requires a value of type 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary`1[[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]'.
Parameter name: viewContext
   at Microsoft.AspNetCore.Mvc.ViewFeatures.HtmlHelper`1.Contextualize(ViewContext viewContext)
   at Microsoft.AspNetCore.Mvc.Razor.Internal.RazorPagePropertyActivator.<>c__DisplayClass8_0.<CreateActivateInfo>b__1(ViewContext context)
   at Microsoft.Extensions.Internal.PropertyActivator`1.Activate(Object instance, TContext context)
   at Microsoft.AspNetCore.Mvc.Razor.Internal.RazorPagePropertyActivator.Activate(Object page, ViewContext context)
   at Microsoft.AspNetCore.Mvc.Razor.RazorPageActivator.Activate(IRazorPage page, ViewContext context)
   at Microsoft.AspNetCore.Mvc.Razor.RazorView.<RenderPageCoreAsync>d__16.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.Razor.RazorView.<RenderViewStartsAsync>d__17.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.Razor.RazorView.<RenderPageAsync>d__15.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()
   at Microsoft.AspNetCore.Mvc.Razor.RazorView.<RenderAsync>d__14.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.ViewFeatures.ViewExecutor.<ExecuteAsync>d__22.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeResultAsync>d__19.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeNextResultFilterAsync>d__24.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResultExecutedContext context)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeNextResourceFilter>d__22.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResourceExecutedContext context)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeFilterPipelineAsync>d__17.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeAsync>d__15.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Builder.RouterMiddleware.<Invoke>d__4.MoveNext()
--- End of stack trace from previous location where exception was thrown ---
   at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
   at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
   at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.<Invoke>d__7.MoveNext()
```
