SG
==

This is a WPF/Prism application using Entity Framework 4.3, Visual Studio 2010

The SG WPF/Prism app was designed to be a project that I can

1.  Learn Prism, XAML, Unit Testing and programming to Interfaces using MVVM

2.  In learning these technologies and patterns I want to learn best practices from
  using Repositories, Unit of Work, Singletons, and other patterns as well as how to 
	structure medium sized projects within Visual Studio.

3.  I wanted to learn Entity Framework so my code can interface with the database
	thru EF and I can work on Model building with Clean POCO's.

4.  Ok, if you are viewing this then you are viewing the code as well.
	Here are the most prominent tasks that need to be resolved.

a.  The design is meant to at first profile me with an intro, a video, and some social media.
	  In the menu, there will be at least buttons that will give you options for profiling different areas of this app.
	  If you choose to Price shop, then the Banner, Content, Social, and Video views
	  will change to preview the organic coop application.  This application is how I taught myself
	  mapping in Entity Framework.  The idea of this coop app is to be able to interface with a local grocery
	  store service in which I can get the latest prices for fruit and vegitables thru their service,
	  a service which I will write, then in the content view, the prices for various fruits/vegis will be
	  compared.  This part of the application is just an excercise in Services, Entity Framework,
	  and XAML design, and swapping Views in various regions depending on what menu item is chosen.


b.  Testing the Prism portion of this app needs work.  I originally was going to use NUnit because this is
	 the testing framework I have used previously but there are so many cool upgrades to MSTest
	 that I would like to utilize this framework as well so I can become more familiar with it's capabilities
	 as far as unit/load/database testing goes.

c.  I would like to have the UI (Views) be more responsive and device driven, such is the case with Media Queries
	in HTML5, CSS3.  Obviously, the UI needs work.

d.  Discussions with several friends about the design of using DI and the Unity Container as well
     as the best way to implement logging in a design/testing environment and an actual Production environment still
	 needs to happen.  Basically I want to know if I am using Dependency Injection by injecting the container
	 in specifically the ModuleMain.cs files (Any one of the Modules in the projects that are under the Modules folder).

e.  I need to complete the work on the repositories and probably utilize factories in my Bounded contexts because 
	I want to be able to swap the context depending on if the user is Price shopping or just checking out the app, or setting
	up a user profile.  The User profile work I need to complete is to learn EF validation as well as other types of security
	and validation.  More to come on that.


	While I work part time currently and I have various other responsibilities this project has taken a pretty high priority
	and to manage my tasks I have been using Trello to set up my task lists and track my done tasks.
	I am always looking for a great way to track tasks in programming (yes beside the obvious, getting VS2012 and Team Foundation
	Studio) so any suggestions along those lines will be greatly appreciated.

	This is definitely a work in progress and managing state, configuration settings in config files and managing 3rd party API's thru nuget are also topics that need to be explored.

	The goal for me is to have these topics under my belt by the spring of 2014 so I can start getting really creative.  I also want to dive into MVC 4 using knockout and various other javascript libraries.  I also have a project along that line that I will update Github with.

	Cherrio!   Blogs on how I solved many of these problems are soon to come. 

	@SapphireGirl10
	
