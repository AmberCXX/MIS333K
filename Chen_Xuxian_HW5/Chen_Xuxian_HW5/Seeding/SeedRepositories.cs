using Chen_Xuxian_HW5.Models;
using Chen_Xuxian_HW5.DAL;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Chen_Xuxian_HW5.Seeding
{
	public static class SeedRepositories
	{
		public static void SeedAllRepositories(AppDbContext db)
		{
			if (db.Repositories.Count() == 250)
			{
				throw new NotSupportedException("The database already contains all 250 repositories!");
			}

			Int32 intReposAdded = 0;
			String repoName = "Begin"; //helps to keep track of error on repos
			List<Repository> Repositories = new List<Repository>();

			try
			{
				Repository r1 = new Repository();
				r1.UserName = "freeCodeCamp";
				r1.RepositoryName = "freeCodeCamp";
				r1.Description = "The https://freeCodeCamp.com open source codebase and curriculum. Learn to code and help nonprofits.";
				r1.Tags = "nonprofits,certification,curriculum,react,nodejs,javascript,d3,teachers,community,education,programming,math,learn-to-code,careers";
				r1.URL = "https://github.com/freeCodeCamp/freeCodeCamp";
				r1.LastUpdate = new DateTime(2017, 6, 24);
				r1.StarCount = 290m;
				r1.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r1);

				Repository r2 = new Repository();
				r2.UserName = "twbs";
				r2.RepositoryName = "bootstrap";
				r2.Description = "The most popular HTML, CSS, and JavaScript framework for developing responsive, mobile first projects on the web.";
				r2.Tags = "javascript,css,html,bootstrap,jekyll-site,scss";
				r2.URL = "https://github.com/twbs/bootstrap";
				r2.LastUpdate = new DateTime(2017, 6, 24);
				r2.StarCount = 112m;
				r2.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r2);

				Repository r3 = new Repository();
				r3.UserName = "EbookFoundation";
				r3.RepositoryName = "free-programming-books";
				r3.Description = " Freely available programming books";
				r3.Tags = "education,list,books,resource";
				r3.URL = "https://github.com/EbookFoundation/free-programming-books";
				r3.LastUpdate = new DateTime(2017, 6, 23);
				r3.StarCount = 87.8m;
				r3.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r3);

				Repository r4 = new Repository();
				r4.UserName = "facebook";
				r4.RepositoryName = "react";
				r4.Description = "A declarative, efficient, and flexible JavaScript library for building user interfaces.";
				r4.Tags = "";
				r4.URL = "https://github.com/facebook/react";
				r4.LastUpdate = new DateTime(2017, 6, 24);
				r4.StarCount = 69.7m;
				r4.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r4);

				Repository r5 = new Repository();
				r5.UserName = "d3";
				r5.RepositoryName = "d3";
				r5.Description = "Bring data to life with SVG, Canvas and HTML. ";
				r5.Tags = "visualization";
				r5.URL = "https://github.com/d3/d3";
				r5.LastUpdate = new DateTime(2017, 5, 31);
				r5.StarCount = 65.7m;
				r5.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r5);

				Repository r6 = new Repository();
				r6.UserName = "getify";
				r6.RepositoryName = "You-Dont-Know-JS";
				r6.Description = "A book series on JavaScript. @YDKJS on twitter.";
				r6.Tags = "book-series,javascript,training-materials,async,education,programming,es6,book,es2015,learn-to-code,training-providers,closures,prototypes";
				r6.URL = "https://github.com/getify/You-Dont-Know-JS";
				r6.LastUpdate = new DateTime(2017, 6, 23);
				r6.StarCount = 62m;
				r6.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r6);

				Repository r7 = new Repository();
				r7.UserName = "tensorflow";
				r7.RepositoryName = "tensorflow";
				r7.Description = "Computation using data flow graphs for scalable machine learning";
				r7.Tags = "tensorflow,python,machine-learning,deep-neural-networks,deep-learning,neural-network,ml,distributed";
				r7.URL = "https://github.com/tensorflow/tensorflow";
				r7.LastUpdate = new DateTime(2017, 6, 24);
				r7.StarCount = 61.6m;
				r7.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r7);

				Repository r8 = new Repository();
				r8.UserName = "sindresorhus";
				r8.RepositoryName = "awesome";
				r8.Description = " Curated list of awesome lists";
				r8.Tags = "lists,awesome,unicorns,resources,awesome-list";
				r8.URL = "https://github.com/sindresorhus/awesome";
				r8.LastUpdate = new DateTime(2017, 6, 24);
				r8.StarCount = 60.7m;
				r8.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r8);

				Repository r9 = new Repository();
				r9.UserName = "vuejs";
				r9.RepositoryName = "vue";
				r9.Description = "A progressive, incrementally-adoptable JavaScript framework for building UI on the web.";
				r9.Tags = "javascript,vue,framework,frontend";
				r9.URL = "https://github.com/vuejs/vue";
				r9.LastUpdate = new DateTime(2017, 6, 24);
				r9.StarCount = 57.7m;
				r9.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r9);

				Repository r10 = new Repository();
				r10.UserName = "angular";
				r10.RepositoryName = "angular.js";
				r10.Description = "AngularJS - HTML enhanced for web apps!";
				r10.Tags = "";
				r10.URL = "https://github.com/angular/angular.js";
				r10.LastUpdate = new DateTime(2017, 6, 24);
				r10.StarCount = 56.2m;
				r10.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r10);

				Repository r11 = new Repository();
				r11.UserName = "robbyrussell";
				r11.RepositoryName = "oh-my-zsh";
				r11.Description = "A delightful community-driven (with 1,000+ contributors) framework for managing your zsh configuration. Includes 200+";
				r11.Tags = "zsh-configuration,shell,theme,productivity,terminal";
				r11.URL = "https://github.com/robbyrussell/oh-my-zsh";
				r11.LastUpdate = new DateTime(2017, 6, 23);
				r11.StarCount = 55.2m;
				r11.Language = db.Languages.FirstOrDefault(x => x.Name == "Shell");
				Repositories.Add(r11);

				Repository r12 = new Repository();
				r12.UserName = "airbnb";
				r12.RepositoryName = "javascript";
				r12.Description = "JavaScript Style Guide";
				r12.Tags = "arrow-functions,javascript,eslint,naming-conventions,styleguide,es6,style-linter,linting,style-guide,es2015";
				r12.URL = "https://github.com/airbnb/javascript";
				r12.LastUpdate = new DateTime(2017, 6, 24);
				r12.StarCount = 54.1m;
				r12.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r12);

				Repository r13 = new Repository();
				r13.UserName = "github";
				r13.RepositoryName = "gitignore";
				r13.Description = "A collection of useful .gitignore templates";
				r13.Tags = "gitignore,git";
				r13.URL = "https://github.com/github/gitignore";
				r13.LastUpdate = new DateTime(2017, 6, 24);
				r13.StarCount = 51.6m;
				r13.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r13);

				Repository r14 = new Repository();
				r14.UserName = "FortAwesome";
				r14.RepositoryName = "Font-Awesome";
				r14.Description = "The iconic font and CSS toolkit";
				r14.Tags = "";
				r14.URL = "https://github.com/FortAwesome/Font-Awesome";
				r14.LastUpdate = new DateTime(2017, 6, 20);
				r14.StarCount = 50.9m;
				r14.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r14);

				Repository r15 = new Repository();
				r15.UserName = "facebook";
				r15.RepositoryName = "react-native";
				r15.Description = "A framework for building native apps with React.";
				r15.Tags = "";
				r15.URL = "https://github.com/facebook/react-native";
				r15.LastUpdate = new DateTime(2017, 6, 24);
				r15.StarCount = 50m;
				r15.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r15);

				Repository r16 = new Repository();
				r16.UserName = "electron";
				r16.RepositoryName = "electron";
				r16.Description = "Build cross platform desktop apps with JavaScript, HTML, and CSS";
				r16.Tags = "html,css,javascript,electron,c-plus-plus,chrome,nodejs,v8";
				r16.URL = "https://github.com/electron/electron";
				r16.LastUpdate = new DateTime(2017, 6, 24);
				r16.StarCount = 47.2m;
				r16.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r16);

				Repository r17 = new Repository();
				r17.UserName = "torvalds";
				r17.RepositoryName = "linux";
				r17.Description = "Linux kernel source tree";
				r17.Tags = "";
				r17.URL = "https://github.com/torvalds/linux";
				r17.LastUpdate = new DateTime(2017, 6, 24);
				r17.StarCount = 46.3m;
				r17.Language = db.Languages.FirstOrDefault(x => x.Name == "C");
				Repositories.Add(r17);

				Repository r18 = new Repository();
				r18.UserName = "jquery";
				r18.RepositoryName = "jquery";
				r18.Description = "jQuery JavaScript Library";
				r18.Tags = "";
				r18.URL = "https://github.com/jquery/jquery";
				r18.LastUpdate = new DateTime(2017, 6, 23);
				r18.StarCount = 45.3m;
				r18.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r18);

				Repository r19 = new Repository();
				r19.UserName = "jwasham";
				r19.RepositoryName = "coding-interview-university";
				r19.Description = "A complete computer science study plan to become a software engineer.";
				r19.Tags = "";
				r19.URL = "https://github.com/jwasham/coding-interview-university";
				r19.LastUpdate = new DateTime(2017, 6, 19);
				r19.StarCount = 44.9m;
				r19.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r19);

				Repository r20 = new Repository();
				r20.UserName = "moby";
				r20.RepositoryName = "moby";
				r20.Description = "Moby Project - a collaborative project for the container ecosystem to assemble container-based systems";
				r20.Tags = "docker,go,containers";
				r20.URL = "https://github.com/moby/moby";
				r20.LastUpdate = new DateTime(2017, 6, 24);
				r20.StarCount = 44.3m;
				r20.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r20);

				Repository r21 = new Repository();
				r21.UserName = "daneden";
				r21.RepositoryName = "animate.css";
				r21.Description = " A cross-browser library of CSS animations. As easy to use as an easy thing.";
				r21.Tags = "css-animations,stylesheets,css,animation";
				r21.URL = "https://github.com/daneden/animate.css";
				r21.LastUpdate = new DateTime(2017, 6, 18);
				r21.StarCount = 42.8m;
				r21.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r21);

				Repository r22 = new Repository();
				r22.UserName = "apple";
				r22.RepositoryName = "swift";
				r22.Description = "The Swift Programming Language";
				r22.Tags = "";
				r22.URL = "https://github.com/apple/swift";
				r22.LastUpdate = new DateTime(2017, 6, 24);
				r22.StarCount = 39.1m;
				r22.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r22);

				Repository r23 = new Repository();
				r23.UserName = "atom";
				r23.RepositoryName = "atom";
				r23.Description = "The hackable text editor";
				r23.Tags = "linux,macos,atom,javascript,electron,editor,windows";
				r23.URL = "https://github.com/atom/atom";
				r23.LastUpdate = new DateTime(2017, 6, 24);
				r23.StarCount = 37.8m;
				r23.Language = db.Languages.FirstOrDefault(x => x.Name == "CoffeeScript");
				Repositories.Add(r23);

				Repository r24 = new Repository();
				r24.UserName = "meteor";
				r24.RepositoryName = "meteor";
				r24.Description = "Meteor, the JavaScript App Platform";
				r24.Tags = "javascript,meteor,npm,mongodb,build-system";
				r24.URL = "https://github.com/meteor/meteor";
				r24.LastUpdate = new DateTime(2017, 6, 24);
				r24.StarCount = 37.7m;
				r24.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r24);

				Repository r25 = new Repository();
				r25.UserName = "h5bp";
				r25.RepositoryName = "html5-boilerplate";
				r25.Description = "A professional front-end template for building fast, robust, and adaptable web apps or sites.";
				r25.Tags = "";
				r25.URL = "https://github.com/h5bp/html5-boilerplate";
				r25.LastUpdate = new DateTime(2017, 6, 11);
				r25.StarCount = 37.6m;
				r25.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r25);

				Repository r26 = new Repository();
				r26.UserName = "nodejs";
				r26.RepositoryName = "node";
				r26.Description = "Node.js JavaScript runtime ";
				r26.Tags = "javascript,nodejs,windows,macos,linux,node,mit,js,runtime";
				r26.URL = "https://github.com/nodejs/node";
				r26.LastUpdate = new DateTime(2017, 6, 24);
				r26.StarCount = 36.4m;
				r26.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r26);

				Repository r27 = new Repository();
				r27.UserName = "nodejs";
				r27.RepositoryName = "node-v0.x-archive";
				r27.Description = "Moved to https://github.com/nodejs/node";
				r27.Tags = "";
				r27.URL = "https://github.com/nodejs/node-v0.x-archive";
				r27.LastUpdate = new DateTime(2016, 8, 3);
				r27.StarCount = 36.4m;
				r27.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r27);

				Repository r28 = new Repository();
				r28.UserName = "rails";
				r28.RepositoryName = "rails";
				r28.Description = "Ruby on Rails";
				r28.Tags = "rails,ruby,html,mvc,activerecord,activejob";
				r28.URL = "https://github.com/rails/rails";
				r28.LastUpdate = new DateTime(2017, 6, 24);
				r28.StarCount = 36.1m;
				r28.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r28);

				Repository r29 = new Repository();
				r29.UserName = "Semantic-Org";
				r29.RepositoryName = "Semantic-UI";
				r29.Description = "Semantic is a UI component framework based around useful principles from natural language.";
				r29.Tags = "semantic,flexbox,ui,css-framework,tooltip,button,popup,dropdown,sidebar,ui-components";
				r29.URL = "https://github.com/Semantic-Org/Semantic-UI";
				r29.LastUpdate = new DateTime(2017, 6, 19);
				r29.StarCount = 35.6m;
				r29.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r29);

				Repository r30 = new Repository();
				r30.UserName = "vinta";
				r30.RepositoryName = "awesome-python";
				r30.Description = "A curated list of awesome Python frameworks, libraries, software and resources";
				r30.Tags = "python,awesome,collections";
				r30.URL = "https://github.com/vinta/awesome-python";
				r30.LastUpdate = new DateTime(2017, 6, 18);
				r30.StarCount = 35.3m;
				r30.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r30);

				Repository r31 = new Repository();
				r31.UserName = "hakimel";
				r31.RepositoryName = "reveal.js";
				r31.Description = "The HTML Presentation Framework";
				r31.Tags = "slideshow,slides,presentations";
				r31.URL = "https://github.com/hakimel/reveal.js";
				r31.LastUpdate = new DateTime(2017, 6, 19);
				r31.StarCount = 35.2m;
				r31.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r31);

				Repository r32 = new Repository();
				r32.UserName = "socketio";
				r32.RepositoryName = "socket.io";
				r32.Description = "Realtime application framework (Node.JS server)";
				r32.Tags = "";
				r32.URL = "https://github.com/socketio/socket.io";
				r32.LastUpdate = new DateTime(2017, 6, 23);
				r32.StarCount = 33.8m;
				r32.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r32);

				Repository r33 = new Repository();
				r33.UserName = "mrdoob";
				r33.RepositoryName = "three.js";
				r33.Description = "JavaScript 3D library.";
				r33.Tags = "javascript,svg,webgl,html5,canvas,scene-graph";
				r33.URL = "https://github.com/mrdoob/three.js";
				r33.LastUpdate = new DateTime(2017, 6, 24);
				r33.StarCount = 33.6m;
				r33.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r33);

				Repository r34 = new Repository();
				r34.UserName = "laravel";
				r34.RepositoryName = "laravel";
				r34.Description = "A PHP Framework For Web Artisans";
				r34.Tags = "php,laravel,framework";
				r34.URL = "https://github.com/laravel/laravel";
				r34.LastUpdate = new DateTime(2017, 6, 23);
				r34.StarCount = 32.9m;
				r34.Language = db.Languages.FirstOrDefault(x => x.Name == "PHP");
				Repositories.Add(r34);

				Repository r35 = new Repository();
				r35.UserName = "expressjs";
				r35.RepositoryName = "express";
				r35.Description = "Fast, unopinionated, minimalist web framework for node.";
				r35.Tags = "javascript,nodejs,express,server";
				r35.URL = "https://github.com/expressjs/express";
				r35.LastUpdate = new DateTime(2017, 6, 22);
				r35.StarCount = 32.5m;
				r35.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r35);

				Repository r36 = new Repository();
				r36.UserName = "reactjs";
				r36.RepositoryName = "redux";
				r36.Description = "Predictable state container for JavaScript apps";
				r36.Tags = "redux";
				r36.URL = "https://github.com/reactjs/redux";
				r36.LastUpdate = new DateTime(2017, 6, 23);
				r36.StarCount = 32m;
				r36.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r36);

				Repository r37 = new Repository();
				r37.UserName = "moment";
				r37.RepositoryName = "moment";
				r37.Description = "Parse, validate, manipulate, and display dates in javascript.";
				r37.Tags = "";
				r37.URL = "https://github.com/moment/moment";
				r37.LastUpdate = new DateTime(2017, 6, 24);
				r37.StarCount = 31.9m;
				r37.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r37);

				Repository r38 = new Repository();
				r38.UserName = "nwjs";
				r38.RepositoryName = "nw.js";
				r38.Description = "Call all Node.js modules directly from DOM/WebWorker and enable a new way of writing applications with all Web techno";
				r38.Tags = "intel,node-webkit,nwjs,javascript,desktop,web-application-framework";
				r38.URL = "https://github.com/nwjs/nw.js";
				r38.LastUpdate = new DateTime(2017, 6, 23);
				r38.StarCount = 31.8m;
				r38.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r38);

				Repository r39 = new Repository();
				r39.UserName = "impress";
				r39.RepositoryName = "impress.js";
				r39.Description = "It's a presentation framework based on the power of CSS3 transforms and transitions in modern browsers and inspired b";
				r39.Tags = "";
				r39.URL = "https://github.com/impress/impress.js";
				r39.LastUpdate = new DateTime(2017, 5, 15);
				r39.StarCount = 31.8m;
				r39.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r39);

				Repository r40 = new Repository();
				r40.UserName = "jlevy";
				r40.RepositoryName = "the-art-of-command-line";
				r40.Description = "Master the command line, in one page";
				r40.Tags = "";
				r40.URL = "https://github.com/jlevy/the-art-of-command-line";
				r40.LastUpdate = new DateTime(2017, 6, 12);
				r40.StarCount = 31m;
				r40.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r40);

				Repository r41 = new Repository();
				r41.UserName = "chartjs";
				r41.RepositoryName = "Chart.js";
				r41.Description = "Simple HTML5 Charts using the <canvas> tag";
				r41.Tags = "html5-charts,chart,javascript,html5,canvas,graph";
				r41.URL = "https://github.com/chartjs/Chart.js";
				r41.LastUpdate = new DateTime(2017, 6, 24);
				r41.StarCount = 30.7m;
				r41.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r41);

				Repository r42 = new Repository();
				r42.UserName = "google";
				r42.RepositoryName = "material-design-icons";
				r42.Description = "Material Design icons by Google";
				r42.Tags = "material,sprites,icons,android,ios,web,material-design";
				r42.URL = "https://github.com/google/material-design-icons";
				r42.LastUpdate = new DateTime(2017, 6, 23);
				r42.StarCount = 30.2m;
				r42.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r42);

				Repository r43 = new Repository();
				r43.UserName = "jakubroztocil";
				r43.RepositoryName = "httpie";
				r43.Description = "Modern command line HTTP client  user-friendly curl alternative with intuitive UI, JSON support, syntax highlighting";
				r43.Tags = "python,debugging,cli,http,client,json,development,terminal,web,rest,curl,http-client,wget,developer-tools,usability,httpie";
				r43.URL = "https://github.com/jakubroztocil/httpie";
				r43.LastUpdate = new DateTime(2017, 6, 18);
				r43.StarCount = 30.2m;
				r43.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r43);

				Repository r44 = new Repository();
				r44.UserName = "jekyll";
				r44.RepositoryName = "jekyll";
				r44.Description = " Jekyll is a blog-aware, static site generator in Ruby";
				r44.Tags = "ruby,jekyll,static-site-generator";
				r44.URL = "https://github.com/jekyll/jekyll";
				r44.LastUpdate = new DateTime(2017, 6, 24);
				r44.StarCount = 30.1m;
				r44.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r44);

				Repository r45 = new Repository();
				r45.UserName = "ionic-team";
				r45.RepositoryName = "ionic";
				r45.Description = "Build amazing native and progressive web apps with open web technologies. One app running on everything ";
				r45.Tags = "ionic,javascript,angular,mobile,framework,typescript,web,pwa,frontend";
				r45.URL = "https://github.com/ionic-team/ionic";
				r45.LastUpdate = new DateTime(2017, 6, 24);
				r45.StarCount = 30.1m;
				r45.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r45);

				Repository r46 = new Repository();
				r46.UserName = "Microsoft";
				r46.RepositoryName = "vscode";
				r46.Description = "Visual Studio Code";
				r46.Tags = "electron,microsoft,editor,typescript,visual-studio-code";
				r46.URL = "https://github.com/Microsoft/vscode";
				r46.LastUpdate = new DateTime(2017, 6, 24);
				r46.StarCount = 29.6m;
				r46.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r46);

				Repository r47 = new Repository();
				r47.UserName = "webpack";
				r47.RepositoryName = "webpack";
				r47.Description = "A bundler for javascript and friends. Packs many modules into a few bundled assets. Code Splitting allows to load par";
				r47.Tags = "javascript,webpack,commonjs,amd,module-loader,web-performance,web,es6,compiler,es2015,plugins,javascript-compiler,webpack2,build-tool,loaders,module-bundler,esm,javascript-modules";
				r47.URL = "https://github.com/webpack/webpack";
				r47.LastUpdate = new DateTime(2017, 6, 24);
				r47.StarCount = 29.4m;
				r47.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r47);

				Repository r48 = new Repository();
				r48.UserName = "AFNetworking";
				r48.RepositoryName = "AFNetworking";
				r48.Description = "A delightful networking framework for iOS, OS X, watchOS, and tvOS.";
				r48.Tags = "";
				r48.URL = "https://github.com/AFNetworking/AFNetworking";
				r48.LastUpdate = new DateTime(2017, 6, 21);
				r48.StarCount = 29.4m;
				r48.Language = db.Languages.FirstOrDefault(x => x.Name == "Objective-C");
				Repositories.Add(r48);

				Repository r49 = new Repository();
				r49.UserName = "resume";
				r49.RepositoryName = "resume.github.com";
				r49.Description = "Resumes generated using the GitHub informations";
				r49.Tags = "";
				r49.URL = "https://github.com/resume/resume.github.com";
				r49.LastUpdate = new DateTime(2017, 1, 30);
				r49.StarCount = 29.4m;
				r49.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r49);

				Repository r50 = new Repository();
				r50.UserName = "golang";
				r50.RepositoryName = "go";
				r50.Description = "The Go programming language";
				r50.Tags = "go,programming-language,language";
				r50.URL = "https://github.com/golang/go";
				r50.LastUpdate = new DateTime(2017, 6, 24);
				r50.StarCount = 29.2m;
				r50.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r50);

				Repository r51 = new Repository();
				r51.UserName = "facebookincubator";
				r51.RepositoryName = "create-react-app";
				r51.Description = "Create React apps with no build configuration.";
				r51.Tags = "react,zero-configuration,build-tools";
				r51.URL = "https://github.com/facebookincubator/create-react-app";
				r51.LastUpdate = new DateTime(2017, 6, 23);
				r51.StarCount = 29.1m;
				r51.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r51);

				Repository r52 = new Repository();
				r52.UserName = "Homebrew";
				r52.RepositoryName = "legacy-homebrew";
				r52.Description = " The former home of Homebrew";
				r52.Tags = "";
				r52.URL = "https://github.com/Homebrew/legacy-homebrew";
				r52.LastUpdate = new DateTime(2017, 5, 27);
				r52.StarCount = 29m;
				r52.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r52);

				Repository r53 = new Repository();
				r53.UserName = "nvbn";
				r53.RepositoryName = "thefuck";
				r53.Description = "Magnificent app which corrects your previous console command.";
				r53.Tags = "python,shell";
				r53.URL = "https://github.com/nvbn/thefuck";
				r53.LastUpdate = new DateTime(2017, 6, 19);
				r53.StarCount = 28.6m;
				r53.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r53);

				Repository r54 = new Repository();
				r54.UserName = "h5bp";
				r54.RepositoryName = "Front-end-Developer-Interview-Questions";
				r54.Description = "A list of helpful front-end related questions you can use to interview potential candidates, test yourself or complet";
				r54.Tags = "";
				r54.URL = "https://github.com/h5bp/Front-end-Developer-Interview-Questions";
				r54.LastUpdate = new DateTime(2017, 6, 22);
				r54.StarCount = 28.2m;
				r54.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r54);

				Repository r55 = new Repository();
				r55.UserName = "google";
				r55.RepositoryName = "material-design-lite";
				r55.Description = "Material Design Components in HTML/CSS/JS";
				r55.Tags = "";
				r55.URL = "https://github.com/google/material-design-lite";
				r55.LastUpdate = new DateTime(2017, 6, 23);
				r55.StarCount = 27.8m;
				r55.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r55);

				Repository r56 = new Repository();
				r56.UserName = "pallets";
				r56.RepositoryName = "flask";
				r56.Description = "A microframework based on Werkzeug, Jinja2 and good intentions";
				r56.Tags = "python,flask,web-framework,wsgi,jinja,werkzeug";
				r56.URL = "https://github.com/pallets/flask";
				r56.LastUpdate = new DateTime(2017, 6, 21);
				r56.StarCount = 27.8m;
				r56.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r56);

				Repository r57 = new Repository();
				r57.UserName = "NARKOZ";
				r57.RepositoryName = "hacker-scripts";
				r57.Description = "Based on a true story";
				r57.Tags = "";
				r57.URL = "https://github.com/NARKOZ/hacker-scripts";
				r57.LastUpdate = new DateTime(2017, 5, 14);
				r57.StarCount = 27.8m;
				r57.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r57);

				Repository r58 = new Repository();
				r58.UserName = "adobe";
				r58.RepositoryName = "brackets";
				r58.Description = "An open source code editor for the web, written in JavaScript, HTML and CSS.";
				r58.Tags = "";
				r58.URL = "https://github.com/adobe/brackets";
				r58.LastUpdate = new DateTime(2017, 6, 23);
				r58.StarCount = 27.6m;
				r58.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r58);

				Repository r59 = new Repository();
				r59.UserName = "Dogfalo";
				r59.RepositoryName = "materialize";
				r59.Description = "Materialize, a CSS Framework based on Material Design";
				r59.Tags = "material,css,design";
				r59.URL = "https://github.com/Dogfalo/materialize";
				r59.LastUpdate = new DateTime(2017, 6, 24);
				r59.StarCount = 27.2m;
				r59.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r59);

				Repository r60 = new Repository();
				r60.UserName = "rg3";
				r60.RepositoryName = "youtube-dl";
				r60.Description = "Command-line program to download videos from YouTube.com and other video sites";
				r60.Tags = "";
				r60.URL = "https://github.com/rg3/youtube-dl";
				r60.LastUpdate = new DateTime(2017, 6, 24);
				r60.StarCount = 26.9m;
				r60.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r60);

				Repository r61 = new Repository();
				r61.UserName = "blueimp";
				r61.RepositoryName = "jQuery-File-Upload";
				r61.Description = "File Upload widget with multiple file selection, drag&drop support, progress bar, validation and preview images, audi";
				r61.Tags = "";
				r61.URL = "https://github.com/blueimp/jQuery-File-Upload";
				r61.LastUpdate = new DateTime(2017, 5, 18);
				r61.StarCount = 26.9m;
				r61.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r61);

				Repository r62 = new Repository();
				r62.UserName = "necolas";
				r62.RepositoryName = "normalize.css";
				r62.Description = "A collection of HTML element and attribute style-normalizations";
				r62.Tags = "";
				r62.URL = "https://github.com/necolas/normalize.css";
				r62.LastUpdate = new DateTime(2017, 6, 15);
				r62.StarCount = 26.7m;
				r62.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r62);

				Repository r63 = new Repository();
				r63.UserName = "callemall";
				r63.RepositoryName = "material-ui";
				r63.Description = "React Components that Implement Google's Material Design.";
				r63.Tags = "react-components,material-ui,javascript,google-material,react,material-design";
				r63.URL = "https://github.com/callemall/material-ui";
				r63.LastUpdate = new DateTime(2017, 6, 24);
				r63.StarCount = 26.6m;
				r63.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r63);

				Repository r64 = new Repository();
				r64.UserName = "gulpjs";
				r64.RepositoryName = "gulp";
				r64.Description = "The streaming build system";
				r64.Tags = "";
				r64.URL = "https://github.com/gulpjs/gulp";
				r64.LastUpdate = new DateTime(2017, 6, 24);
				r64.StarCount = 26.6m;
				r64.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r64);

				Repository r65 = new Repository();
				r65.UserName = "django";
				r65.RepositoryName = "django";
				r65.Description = "The Web framework for perfectionists with deadlines.";
				r65.Tags = "python,django,views,framework,orm,web,apps,templates,models";
				r65.URL = "https://github.com/django/django";
				r65.LastUpdate = new DateTime(2017, 6, 24);
				r65.StarCount = 26.4m;
				r65.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r65);

				Repository r66 = new Repository();
				r66.UserName = "jashkenas";
				r66.RepositoryName = "backbone";
				r66.Description = "Give your JS App some Backbone with Models, Views, Collections, and Events";
				r66.Tags = "";
				r66.URL = "https://github.com/jashkenas/backbone";
				r66.LastUpdate = new DateTime(2017, 6, 23);
				r66.StarCount = 26.4m;
				r66.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r66);

				Repository r67 = new Repository();
				r67.UserName = "yarnpkg";
				r67.RepositoryName = "yarn";
				r67.Description = " Fast, reliable, and secure dependency management.";
				r67.Tags = "yarn,npm,package-manager,javascript";
				r67.URL = "https://github.com/yarnpkg/yarn";
				r67.LastUpdate = new DateTime(2017, 6, 24);
				r67.StarCount = 25.9m;
				r67.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r67);

				Repository r68 = new Repository();
				r68.UserName = "zurb";
				r68.RepositoryName = "foundation-sites";
				r68.Description = "The most advanced responsive front-end framework in the world. Quickly create prototypes and production code for site";
				r68.Tags = "";
				r68.URL = "https://github.com/zurb/foundation-sites";
				r68.LastUpdate = new DateTime(2017, 6, 24);
				r68.StarCount = 25.7m;
				r68.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r68);

				Repository r69 = new Repository();
				r69.UserName = "requests";
				r69.RepositoryName = "requests";
				r69.Description = "Python HTTP Requests for Humans ";
				r69.Tags = "python,http,requests,forhumans,kennethreitz";
				r69.URL = "https://github.com/requests/requests";
				r69.LastUpdate = new DateTime(2017, 6, 16);
				r69.StarCount = 25.7m;
				r69.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r69);

				Repository r70 = new Repository();
				r70.UserName = "angular";
				r70.RepositoryName = "angular";
				r70.Description = "One framework. Mobile & desktop.";
				r70.Tags = "angular,typescript,javascript,web-performance,web,pwa,web-framework";
				r70.URL = "https://github.com/angular/angular";
				r70.LastUpdate = new DateTime(2017, 6, 24);
				r70.StarCount = 25.3m;
				r70.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r70);

				Repository r71 = new Repository();
				r71.UserName = "ReactiveX";
				r71.RepositoryName = "RxJava";
				r71.Description = "RxJava  Reactive Extensions for the JVM  a library for composing asynchronous and event-based programs using observ";
				r71.Tags = "flow,reactive-streams,java,rxjava";
				r71.URL = "https://github.com/ReactiveX/RxJava";
				r71.LastUpdate = new DateTime(2017, 6, 24);
				r71.StarCount = 25.2m;
				r71.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r71);

				Repository r72 = new Repository();
				r72.UserName = "chrislgarry";
				r72.RepositoryName = "Apollo-11";
				r72.Description = "Original Apollo 11 Guidance Computer (AGC) source code for the command and lunar modules.";
				r72.Tags = "agc,apollo,nasa";
				r72.URL = "https://github.com/chrislgarry/Apollo-11";
				r72.LastUpdate = new DateTime(2017, 6, 19);
				r72.StarCount = 24.4m;
				r72.Language = db.Languages.FirstOrDefault(x => x.Name == "Assembly");
				Repositories.Add(r72);

				Repository r73 = new Repository();
				r73.UserName = "kubernetes";
				r73.RepositoryName = "kubernetes";
				r73.Description = "Production-Grade Container Scheduling and Management";
				r73.Tags = "cncf,kubernetes,containers,go";
				r73.URL = "https://github.com/kubernetes/kubernetes";
				r73.LastUpdate = new DateTime(2017, 6, 24);
				r73.StarCount = 24.3m;
				r73.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r73);

				Repository r74 = new Repository();
				r74.UserName = "lodash";
				r74.RepositoryName = "lodash";
				r74.Description = "A modern JavaScript utility library delivering modularity, performance, & extras.";
				r74.Tags = "lodash,javascript,modules,utilities";
				r74.URL = "https://github.com/lodash/lodash";
				r74.LastUpdate = new DateTime(2017, 6, 20);
				r74.StarCount = 24.3m;
				r74.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r74);

				Repository r75 = new Repository();
				r75.UserName = "Alamofire";
				r75.RepositoryName = "Alamofire";
				r75.Description = "Elegant HTTP Networking in Swift";
				r75.Tags = "";
				r75.URL = "https://github.com/Alamofire/Alamofire";
				r75.LastUpdate = new DateTime(2017, 6, 18);
				r75.StarCount = 24.1m;
				r75.Language = db.Languages.FirstOrDefault(x => x.Name == "Swift");
				Repositories.Add(r75);

				Repository r76 = new Repository();
				r76.UserName = "antirez";
				r76.RepositoryName = "redis";
				r76.Description = "Redis is an in-memory database that persists on disk. The data model is key-value, but many different kind of values ";
				r76.Tags = "";
				r76.URL = "https://github.com/antirez/redis";
				r76.LastUpdate = new DateTime(2017, 6, 23);
				r76.StarCount = 24m;
				r76.Language = db.Languages.FirstOrDefault(x => x.Name == "C");
				Repositories.Add(r76);

				Repository r77 = new Repository();
				r77.UserName = "ansible";
				r77.RepositoryName = "ansible";
				r77.Description = "Ansible is a radically simple IT automation platform that makes your applications and systems easier to deploy. Avoid";
				r77.Tags = "python,ansible";
				r77.URL = "https://github.com/ansible/ansible";
				r77.LastUpdate = new DateTime(2017, 6, 24);
				r77.StarCount = 23.9m;
				r77.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r77);

				Repository r78 = new Repository();
				r78.UserName = "wasabeef";
				r78.RepositoryName = "awesome-android-ui";
				r78.Description = "A curated list of awesome Android UI/UX libraries";
				r78.Tags = "android,awesome,ui";
				r78.URL = "https://github.com/wasabeef/awesome-android-ui";
				r78.LastUpdate = new DateTime(2017, 6, 10);
				r78.StarCount = 23.9m;
				r78.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r78);

				Repository r79 = new Repository();
				r79.UserName = "getlantern";
				r79.RepositoryName = "lantern";
				r79.Description = "Lantern Latest Download https://github.com/getlantern/lantern/releases/tag/latest  https://github.com/getl";
				r79.Tags = "";
				r79.URL = "https://github.com/getlantern/lantern";
				r79.LastUpdate = new DateTime(2017, 6, 15);
				r79.StarCount = 23.8m;
				r79.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r79);

				Repository r80 = new Repository();
				r80.UserName = "josephmisiti";
				r80.RepositoryName = "awesome-machine-learning";
				r80.Description = "A curated list of awesome Machine Learning frameworks, libraries and software.";
				r80.Tags = "";
				r80.URL = "https://github.com/josephmisiti/awesome-machine-learning";
				r80.LastUpdate = new DateTime(2017, 6, 24);
				r80.StarCount = 23.7m;
				r80.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r80);

				Repository r81 = new Repository();
				r81.UserName = "kamranahmedse";
				r81.RepositoryName = "developer-roadmap";
				r81.Description = "Roadmap to becoming a web developer in 2017";
				r81.Tags = "";
				r81.URL = "https://github.com/kamranahmedse/developer-roadmap";
				r81.LastUpdate = new DateTime(2017, 6, 23);
				r81.StarCount = 23.6m;
				r81.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r81);

				Repository r82 = new Repository();
				r82.UserName = "papers-we-love";
				r82.RepositoryName = "papers-we-love";
				r82.Description = "Papers from the computer science community to read and discuss.";
				r82.Tags = "";
				r82.URL = "https://github.com/papers-we-love/papers-we-love";
				r82.LastUpdate = new DateTime(2017, 6, 10);
				r82.StarCount = 23.6m;
				r82.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r82);

				Repository r83 = new Repository();
				r83.UserName = "elastic";
				r83.RepositoryName = "elasticsearch";
				r83.Description = "Open Source, Distributed, RESTful Search Engine";
				r83.Tags = "java,search-engine,elasticsearch";
				r83.URL = "https://github.com/elastic/elasticsearch";
				r83.LastUpdate = new DateTime(2017, 6, 24);
				r83.StarCount = 23.4m;
				r83.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r83);

				Repository r84 = new Repository();
				r84.UserName = "Trinea";
				r84.RepositoryName = "android-open-project";
				r84.Description = "A categorized collection of Android Open Source Projects : codekk";
				r84.Tags = "android,open-source-project";
				r84.URL = "https://github.com/Trinea/android-open-project";
				r84.LastUpdate = new DateTime(2017, 6, 22);
				r84.StarCount = 23.3m;
				r84.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r84);

				Repository r85 = new Repository();
				r85.UserName = "neovim";
				r85.RepositoryName = "neovim";
				r85.Description = "Vim-fork focused on extensibility and usability.";
				r85.Tags = "c,neovim,vim,lua,nvim,text-editor,cross-platform,extensible,api";
				r85.URL = "https://github.com/neovim/neovim";
				r85.LastUpdate = new DateTime(2017, 6, 24);
				r85.StarCount = 23.2m;
				r85.Language = db.Languages.FirstOrDefault(x => x.Name == "Vim script");
				Repositories.Add(r85);

				Repository r86 = new Repository();
				r86.UserName = "Microsoft";
				r86.RepositoryName = "TypeScript";
				r86.Description = "TypeScript is a superset of JavaScript that compiles to clean JavaScript output.";
				r86.Tags = "javascript,typescript,language,typechecker";
				r86.URL = "https://github.com/Microsoft/TypeScript";
				r86.LastUpdate = new DateTime(2017, 6, 23);
				r86.StarCount = 23.2m;
				r86.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r86);

				Repository r87 = new Repository();
				r87.UserName = "nylas";
				r87.RepositoryName = "nylas-mail";
				r87.Description = " An extensible desktop mail app built on the modern web. Forks welcome!";
				r87.Tags = "linux,javascript,nylas-mail,electron,react,windows,macos,flux,productivity,babel,email";
				r87.URL = "https://github.com/nylas/nylas-mail";
				r87.LastUpdate = new DateTime(2017, 6, 6);
				r87.StarCount = 23.1m;
				r87.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r87);

				Repository r88 = new Repository();
				r88.UserName = "TryGhost";
				r88.RepositoryName = "Ghost";
				r88.Description = "A simple, powerful publishing platform";
				r88.Tags = "javascript,blogging,journalism,publishing,web-application";
				r88.URL = "https://github.com/TryGhost/Ghost";
				r88.LastUpdate = new DateTime(2017, 6, 24);
				r88.StarCount = 23m;
				r88.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r88);

				Repository r89 = new Repository();
				r89.UserName = "ReactTraining";
				r89.RepositoryName = "react-router";
				r89.Description = "Declarative routing for React";
				r89.Tags = "";
				r89.URL = "https://github.com/ReactTraining/react-router";
				r89.LastUpdate = new DateTime(2017, 6, 23);
				r89.StarCount = 23m;
				r89.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r89);

				Repository r90 = new Repository();
				r90.UserName = "johnpapa";
				r90.RepositoryName = "angular-styleguide";
				r90.Description = "Angular Style Guide: A starting point for Angular development teams to provide consistency through good practices.";
				r90.Tags = "";
				r90.URL = "https://github.com/johnpapa/angular-styleguide";
				r90.LastUpdate = new DateTime(2017, 5, 30);
				r90.StarCount = 22.9m;
				r90.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r90);

				Repository r91 = new Repository();
				r91.UserName = "typicode";
				r91.RepositoryName = "json-server";
				r91.Description = "Get a full fake REST API with zero coding in less than 30 seconds (seriously)";
				r91.Tags = "";
				r91.URL = "https://github.com/typicode/json-server";
				r91.LastUpdate = new DateTime(2017, 6, 22);
				r91.StarCount = 22.8m;
				r91.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r91);

				Repository r92 = new Repository();
				r92.UserName = "ariya";
				r92.RepositoryName = "phantomjs";
				r92.Description = "Scriptable Headless WebKit";
				r92.Tags = "";
				r92.URL = "https://github.com/ariya/phantomjs";
				r92.LastUpdate = new DateTime(2017, 6, 18);
				r92.StarCount = 22.5m;
				r92.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r92);

				Repository r93 = new Repository();
				r93.UserName = "open-source-society";
				r93.RepositoryName = "computer-science";
				r93.Description = " Path to a free self-taught education in Computer Science!";
				r93.Tags = "computer-science,courses,awesome-list";
				r93.URL = "https://github.com/open-source-society/computer-science";
				r93.LastUpdate = new DateTime(2017, 6, 10);
				r93.StarCount = 22.5m;
				r93.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r93);

				Repository r94 = new Repository();
				r94.UserName = "rust-lang";
				r94.RepositoryName = "rust";
				r94.Description = "A safe, concurrent, practical language.";
				r94.Tags = "rust,compiler";
				r94.URL = "https://github.com/rust-lang/rust";
				r94.LastUpdate = new DateTime(2017, 6, 24);
				r94.StarCount = 22.3m;
				r94.Language = db.Languages.FirstOrDefault(x => x.Name == "Rust");
				Repositories.Add(r94);

				Repository r95 = new Repository();
				r95.UserName = "tiimgreen";
				r95.RepositoryName = "github-cheat-sheet";
				r95.Description = "A list of cool features of Git and GitHub.";
				r95.Tags = "list,awesome,awesome-list";
				r95.URL = "https://github.com/tiimgreen/github-cheat-sheet";
				r95.LastUpdate = new DateTime(2017, 4, 23);
				r95.StarCount = 22.3m;
				r95.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r95);

				Repository r96 = new Repository();
				r96.UserName = "square";
				r96.RepositoryName = "retrofit";
				r96.Description = "Type-safe HTTP client for Android and Java by Square, Inc.";
				r96.Tags = "";
				r96.URL = "https://github.com/square/retrofit";
				r96.LastUpdate = new DateTime(2017, 6, 23);
				r96.StarCount = 22m;
				r96.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r96);

				Repository r97 = new Repository();
				r97.UserName = "discourse";
				r97.RepositoryName = "discourse";
				r97.Description = "A platform for community discussion. Free, open, simple.";
				r97.Tags = "ruby,rails,discourse,emberjs";
				r97.URL = "https://github.com/discourse/discourse";
				r97.LastUpdate = new DateTime(2017, 6, 23);
				r97.StarCount = 21.9m;
				r97.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r97);

				Repository r98 = new Repository();
				r98.UserName = "firehol";
				r98.RepositoryName = "netdata";
				r98.Description = "Get control of your servers. Simple. Effective. Awesome! https://my-netdata.io/";
				r98.Tags = "monitoring,metrics,iot,linux,notifications,macos,agent,docker,freebsd,alarm,status,benchmark,performance,real-time,monitor,dashboard,health-check,web-analytics,statuspage,statsd";
				r98.URL = "https://github.com/firehol/netdata";
				r98.LastUpdate = new DateTime(2017, 6, 22);
				r98.StarCount = 21.9m;
				r98.Language = db.Languages.FirstOrDefault(x => x.Name == "C");
				Repositories.Add(r98);

				Repository r99 = new Repository();
				r99.UserName = "dypsilon";
				r99.RepositoryName = "frontend-dev-bookmarks";
				r99.Description = "Manually curated collection of resources for frontend web developers.";
				r99.Tags = "list,awesome,frontend,awesome-list";
				r99.URL = "https://github.com/dypsilon/frontend-dev-bookmarks";
				r99.LastUpdate = new DateTime(2017, 5, 24);
				r99.StarCount = 21.9m;
				r99.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r99);

				Repository r100 = new Repository();
				r100.UserName = "mzabriskie";
				r100.RepositoryName = "axios";
				r100.Description = "Promise based HTTP client for the browser and node.js";
				r100.Tags = "javascript,promise,nodejs,http-client";
				r100.URL = "https://github.com/mzabriskie/axios";
				r100.LastUpdate = new DateTime(2017, 6, 23);
				r100.StarCount = 21.8m;
				r100.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r100);

				Repository r101 = new Repository();
				r101.UserName = "avelino";
				r101.RepositoryName = "awesome-go";
				r101.Description = "A curated list of awesome Go frameworks, libraries and software";
				r101.Tags = "golang-library,go,golang,awesome,awesome-list";
				r101.URL = "https://github.com/avelino/awesome-go";
				r101.LastUpdate = new DateTime(2017, 6, 24);
				r101.StarCount = 21.6m;
				r101.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r101);

				Repository r102 = new Repository();
				r102.UserName = "caolan";
				r102.RepositoryName = "async";
				r102.Description = "Async utilities for node and the browser";
				r102.Tags = "javascript,async,callbacks";
				r102.URL = "https://github.com/caolan/async";
				r102.LastUpdate = new DateTime(2017, 6, 23);
				r102.StarCount = 21.6m;
				r102.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r102);

				Repository r103 = new Repository();
				r103.UserName = "babel";
				r103.RepositoryName = "babel";
				r103.Description = " Babel is a compiler for writing next generation JavaScript.";
				r103.Tags = "babel,javascript,compiler,ast,flavortown";
				r103.URL = "https://github.com/babel/babel";
				r103.LastUpdate = new DateTime(2017, 6, 24);
				r103.StarCount = 21.5m;
				r103.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r103);

				Repository r104 = new Repository();
				r104.UserName = "tastejs";
				r104.RepositoryName = "todomvc";
				r104.Description = "Helping you select an MV* framework - Todo apps for Backbone.js, Ember.js, AngularJS, and many more";
				r104.Tags = "";
				r104.URL = "https://github.com/tastejs/todomvc";
				r104.LastUpdate = new DateTime(2017, 6, 21);
				r104.StarCount = 21.3m;
				r104.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r104);

				Repository r105 = new Repository();
				r105.UserName = "scrapy";
				r105.RepositoryName = "scrapy";
				r105.Description = "Scrapy, a fast high-level web crawling & scraping framework for Python.";
				r105.Tags = "python,crawler,framework,scraping,crawling";
				r105.URL = "https://github.com/scrapy/scrapy";
				r105.LastUpdate = new DateTime(2017, 6, 23);
				r105.StarCount = 21.2m;
				r105.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r105);

				Repository r106 = new Repository();
				r106.UserName = "minimaxir";
				r106.RepositoryName = "big-list-of-naughty-strings";
				r106.Description = "The Big List of Naughty Strings is a list of strings which have a high probability of causing issues when used as use";
				r106.Tags = "";
				r106.URL = "https://github.com/minimaxir/big-list-of-naughty-strings";
				r106.LastUpdate = new DateTime(2017, 5, 26);
				r106.StarCount = 21.2m;
				r106.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r106);

				Repository r107 = new Repository();
				r107.UserName = "harvesthq";
				r107.RepositoryName = "chosen";
				r107.Description = "Chosen is a library for making long, unwieldy select boxes more friendly.";
				r107.Tags = "";
				r107.URL = "https://github.com/harvesthq/chosen";
				r107.LastUpdate = new DateTime(2017, 6, 22);
				r107.StarCount = 20.9m;
				r107.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r107);

				Repository r108 = new Repository();
				r108.UserName = "jashkenas";
				r108.RepositoryName = "underscore";
				r108.Description = "JavaScript's utility _ belt";
				r108.Tags = "";
				r108.URL = "https://github.com/jashkenas/underscore";
				r108.LastUpdate = new DateTime(2017, 6, 19);
				r108.StarCount = 20.9m;
				r108.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r108);

				Repository r109 = new Repository();
				r109.UserName = "lukehoban";
				r109.RepositoryName = "es6features";
				r109.Description = "Overview of ECMAScript 6 features";
				r109.Tags = "";
				r109.URL = "https://github.com/lukehoban/es6features";
				r109.LastUpdate = new DateTime(2017, 6, 22);
				r109.StarCount = 20.7m;
				r109.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r109);

				Repository r110 = new Repository();
				r110.UserName = "square";
				r110.RepositoryName = "okhttp";
				r110.Description = "An HTTP+HTTP/2 client for Android and Java applications.";
				r110.Tags = "";
				r110.URL = "https://github.com/square/okhttp";
				r110.LastUpdate = new DateTime(2017, 6, 24);
				r110.StarCount = 20.6m;
				r110.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r110);

				Repository r111 = new Repository();
				r111.UserName = "Modernizr";
				r111.RepositoryName = "Modernizr";
				r111.Description = "Modernizr is a JavaScript library that detects HTML5 and CSS3 features in the users browser.";
				r111.Tags = "javascript-library,javascript,css3-features,modernizr,feature-detection";
				r111.URL = "https://github.com/Modernizr/Modernizr";
				r111.LastUpdate = new DateTime(2017, 6, 12);
				r111.StarCount = 20.6m;
				r111.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r111);

				Repository r112 = new Repository();
				r112.UserName = "select2";
				r112.RepositoryName = "select2";
				r112.Description = "Select2 is a jQuery based replacement for select boxes. It supports searching, remote data sets, and infinite scrolli";
				r112.Tags = "javascript,jquery,select2";
				r112.URL = "https://github.com/select2/select2";
				r112.LastUpdate = new DateTime(2017, 6, 21);
				r112.StarCount = 20.5m;
				r112.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r112);

				Repository r113 = new Repository();
				r113.UserName = "vsouza";
				r113.RepositoryName = "awesome-ios";
				r113.Description = "A curated list of awesome iOS ecosystem, including Objective-C and Swift Projects";
				r113.Tags = "swift-wrapper,xcode-plugin,ios-animation,swift-framework,swift-programming,swift-library,swift-extensions,swift-language,awesome,ios,objective-c,objective-c-library,objective-c-extensions,apple-swift";
				r113.URL = "https://github.com/vsouza/awesome-ios";
				r113.LastUpdate = new DateTime(2017, 6, 24);
				r113.StarCount = 20.4m;
				r113.Language = db.Languages.FirstOrDefault(x => x.Name == "Swift");
				Repositories.Add(r113);

				Repository r114 = new Repository();
				r114.UserName = "adam-p";
				r114.RepositoryName = "markdown-here";
				r114.Description = "Google Chrome, Firefox, and Thunderbird extension that lets you write email in Markdown and render it before sending.";
				r114.Tags = "";
				r114.URL = "https://github.com/adam-p/markdown-here";
				r114.LastUpdate = new DateTime(2017, 6, 13);
				r114.StarCount = 20.4m;
				r114.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r114);

				Repository r115 = new Repository();
				r115.UserName = "sahat";
				r115.RepositoryName = "hackathon-starter";
				r115.Description = "A boilerplate for Node.js web applications";
				r115.Tags = "hackathon,nodejs,boilerplate,oauth2";
				r115.URL = "https://github.com/sahat/hackathon-starter";
				r115.LastUpdate = new DateTime(2017, 6, 18);
				r115.StarCount = 20.1m;
				r115.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r115);

				Repository r116 = new Repository();
				r116.UserName = "enaqx";
				r116.RepositoryName = "awesome-react";
				r116.Description = "A collection of awesome things regarding React ecosystem.";
				r116.Tags = "";
				r116.URL = "https://github.com/enaqx/awesome-react";
				r116.LastUpdate = new DateTime(2017, 6, 23);
				r116.StarCount = 20m;
				r116.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r116);

				Repository r117 = new Repository();
				r117.UserName = "creationix";
				r117.RepositoryName = "nvm";
				r117.Description = "Node Version Manager - Simple bash script to manage multiple active node.js versions";
				r117.Tags = "";
				r117.URL = "https://github.com/creationix/nvm";
				r117.LastUpdate = new DateTime(2017, 6, 23);
				r117.StarCount = 19.9m;
				r117.Language = db.Languages.FirstOrDefault(x => x.Name == "Shell");
				Repositories.Add(r117);

				Repository r118 = new Repository();
				r118.UserName = "prakhar1989";
				r118.RepositoryName = "awesome-courses";
				r118.Description = " List of awesome university courses for learning Computer Science!";
				r118.Tags = "computer-science,awesome,courses,awesome-list";
				r118.URL = "https://github.com/prakhar1989/awesome-courses";
				r118.LastUpdate = new DateTime(2017, 6, 19);
				r118.StarCount = 19.8m;
				r118.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r118);

				Repository r119 = new Repository();
				r119.UserName = "iluwatar";
				r119.RepositoryName = "java-design-patterns";
				r119.Description = "Design patterns implemented in Java";
				r119.Tags = "principles,java,design-patterns";
				r119.URL = "https://github.com/iluwatar/java-design-patterns";
				r119.LastUpdate = new DateTime(2017, 6, 15);
				r119.StarCount = 19.8m;
				r119.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r119);

				Repository r120 = new Repository();
				r120.UserName = "gogits";
				r120.RepositoryName = "gogs";
				r120.Description = "Gogs is a painless self-hosted Git service.";
				r120.Tags = "gogs,go,git";
				r120.URL = "https://github.com/gogits/gogs";
				r120.LastUpdate = new DateTime(2017, 6, 21);
				r120.StarCount = 19.7m;
				r120.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r120);

				Repository r121 = new Repository();
				r121.UserName = "Unitech";
				r121.RepositoryName = "pm2";
				r121.Description = "Production process manager for Node.js apps with a built-in load balancer.";
				r121.Tags = "startup-script,pm2,nodejs,process-manager,node,monitoring,manager,deploy,production,process,load-balancer,forever";
				r121.URL = "https://github.com/Unitech/pm2";
				r121.LastUpdate = new DateTime(2017, 6, 23);
				r121.StarCount = 19.5m;
				r121.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r121);

				Repository r122 = new Repository();
				r122.UserName = "gitlabhq";
				r122.RepositoryName = "gitlabhq";
				r122.Description = "GitLab CE | Please open new issues in our issue tracker on GitLab.com";
				r122.Tags = "ruby,gitlab,rails";
				r122.URL = "https://github.com/gitlabhq/gitlabhq";
				r122.LastUpdate = new DateTime(2017, 6, 22);
				r122.StarCount = 19.5m;
				r122.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r122);

				Repository r123 = new Repository();
				r123.UserName = "karan";
				r123.RepositoryName = "Projects";
				r123.Description = " A list of practical projects that anyone can solve in any programming language.";
				r123.Tags = "";
				r123.URL = "https://github.com/karan/Projects";
				r123.LastUpdate = new DateTime(2017, 6, 5);
				r123.StarCount = 19.5m;
				r123.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r123);

				Repository r124 = new Repository();
				r124.UserName = "alvarotrigo";
				r124.RepositoryName = "fullPage.js";
				r124.Description = "fullPage plugin by Alvaro Trigo. Create full screen pages fast and simple";
				r124.Tags = "slide,scrolling,javascript,jquery,slideshow,snap,fullscreen,swipe,onepage,fullpage,sections,mousewheel";
				r124.URL = "https://github.com/alvarotrigo/fullPage.js";
				r124.LastUpdate = new DateTime(2017, 5, 30);
				r124.StarCount = 19.5m;
				r124.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r124);

				Repository r125 = new Repository();
				r125.UserName = "scikit-learn";
				r125.RepositoryName = "scikit-learn";
				r125.Description = "scikit-learn: machine learning in Python";
				r125.Tags = "python,data-science,machine-learning,statistics,data-analysis";
				r125.URL = "https://github.com/scikit-learn/scikit-learn";
				r125.LastUpdate = new DateTime(2017, 6, 24);
				r125.StarCount = 19.4m;
				r125.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r125);

				Repository r126 = new Repository();
				r126.UserName = "facebook";
				r126.RepositoryName = "immutable-js";
				r126.Description = "Immutable persistent data collections for Javascript which increase efficiency and simplicity.";
				r126.Tags = "";
				r126.URL = "https://github.com/facebook/immutable-js";
				r126.LastUpdate = new DateTime(2017, 6, 24);
				r126.StarCount = 19.3m;
				r126.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r126);

				Repository r127 = new Repository();
				r127.UserName = "googlesamples";
				r127.RepositoryName = "android-architecture";
				r127.Description = "A collection of samples to discuss and showcase different architectural tools and patterns for Android apps.";
				r127.Tags = "android-architecture,android,contentprovider,android-development,clean-architecture,samples,dagger2,loaders,mvvm-architecture,databinding,mvp-android,dagger2-mvp,rxjava-android";
				r127.URL = "https://github.com/googlesamples/android-architecture";
				r127.LastUpdate = new DateTime(2017, 6, 23);
				r127.StarCount = 19.3m;
				r127.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r127);

				Repository r128 = new Repository();
				r128.UserName = "caesar0301";
				r128.RepositoryName = "awesome-public-datasets";
				r128.Description = "An awesome list of high-quality open datasets in public domains (on-going). By everyone, for everyone!";
				r128.Tags = "";
				r128.URL = "https://github.com/caesar0301/awesome-public-datasets";
				r128.LastUpdate = new DateTime(2017, 6, 24);
				r128.StarCount = 19.2m;
				r128.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r128);

				Repository r129 = new Repository();
				r129.UserName = "rethinkdb";
				r129.RepositoryName = "rethinkdb";
				r129.Description = "The open-source database for the realtime web.";
				r129.Tags = "";
				r129.URL = "https://github.com/rethinkdb/rethinkdb";
				r129.LastUpdate = new DateTime(2017, 6, 22);
				r129.StarCount = 19.2m;
				r129.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r129);

				Repository r130 = new Repository();
				r130.UserName = "joshbuchea";
				r130.RepositoryName = "HEAD";
				r130.Description = "A list of everything that could go in the <head> of your document";
				r130.Tags = "meta-tags,html5,head";
				r130.URL = "https://github.com/joshbuchea/HEAD";
				r130.LastUpdate = new DateTime(2017, 6, 22);
				r130.StarCount = 19.2m;
				r130.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r130);

				Repository r131 = new Repository();
				r131.UserName = "bayandin";
				r131.RepositoryName = "awesome-awesomeness";
				r131.Description = "A curated list of awesome awesomeness";
				r131.Tags = "";
				r131.URL = "https://github.com/bayandin/awesome-awesomeness";
				r131.LastUpdate = new DateTime(2017, 6, 21);
				r131.StarCount = 19.1m;
				r131.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r131);

				Repository r132 = new Repository();
				r132.UserName = "certbot";
				r132.RepositoryName = "certbot";
				r132.Description = "Certbot, previously the Let's Encrypt Client, is EFF's tool to obtain certs from Let's Encrypt, and (optionally) auto";
				r132.Tags = "python,letsencrypt,acme-client,certificate,acme,certbot";
				r132.URL = "https://github.com/certbot/certbot";
				r132.LastUpdate = new DateTime(2017, 6, 23);
				r132.StarCount = 18.9m;
				r132.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r132);

				Repository r133 = new Repository();
				r133.UserName = "toddmotto";
				r133.RepositoryName = "public-apis";
				r133.Description = "A collective list of public JSON APIs for use in web development.";
				r133.Tags = "";
				r133.URL = "https://github.com/toddmotto/public-apis";
				r133.LastUpdate = new DateTime(2017, 6, 24);
				r133.StarCount = 18.8m;
				r133.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r133);

				Repository r134 = new Repository();
				r134.UserName = "Leaflet";
				r134.RepositoryName = "Leaflet";
				r134.Description = " JavaScript library for mobile-friendly interactive maps";
				r134.Tags = "leaflet,javascript,maps";
				r134.URL = "https://github.com/Leaflet/Leaflet";
				r134.LastUpdate = new DateTime(2017, 6, 24);
				r134.StarCount = 18.7m;
				r134.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r134);

				Repository r135 = new Repository();
				r135.UserName = "BVLC";
				r135.RepositoryName = "caffe";
				r135.Description = "Caffe: a fast open framework for deep learning.";
				r135.Tags = "";
				r135.URL = "https://github.com/BVLC/caffe";
				r135.LastUpdate = new DateTime(2017, 6, 24);
				r135.StarCount = 18.7m;
				r135.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r135);

				Repository r136 = new Repository();
				r136.UserName = "ecomfe";
				r136.RepositoryName = "echarts";
				r136.Description = "A powerful, interactive charting and visualization library for browser";
				r136.Tags = "echarts,javascript,visualization,chart";
				r136.URL = "https://github.com/ecomfe/echarts";
				r136.LastUpdate = new DateTime(2017, 6, 22);
				r136.StarCount = 18.7m;
				r136.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r136);

				Repository r137 = new Repository();
				r137.UserName = "kenwheeler";
				r137.RepositoryName = "slick";
				r137.Description = "the last carousel you'll ever need";
				r137.Tags = "";
				r137.URL = "https://github.com/kenwheeler/slick";
				r137.LastUpdate = new DateTime(2017, 6, 23);
				r137.StarCount = 18.6m;
				r137.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r137);

				Repository r138 = new Repository();
				r138.UserName = "justjavac";
				r138.RepositoryName = "free-programming-books-zh_CN";
				r138.Description = " ";
				r138.Tags = "javascript,python,pdf,android,programming,books,free";
				r138.URL = "https://github.com/justjavac/free-programming-books-zh_CN";
				r138.LastUpdate = new DateTime(2017, 6, 6);
				r138.StarCount = 18.6m;
				r138.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r138);

				Repository r139 = new Repository();
				r139.UserName = "codepath";
				r139.RepositoryName = "android_guides";
				r139.Description = "Extensive Open-Source Guides for Android Developers";
				r139.Tags = "android,codepath,development,tutorials,guides";
				r139.URL = "https://github.com/codepath/android_guides";
				r139.LastUpdate = new DateTime(2017, 5, 15);
				r139.StarCount = 18.6m;
				r139.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r139);

				Repository r140 = new Repository();
				r140.UserName = "mozilla";
				r140.RepositoryName = "pdf.js";
				r140.Description = "PDF Reader in JavaScript";
				r140.Tags = "";
				r140.URL = "https://github.com/mozilla/pdf.js";
				r140.LastUpdate = new DateTime(2017, 6, 23);
				r140.StarCount = 18.3m;
				r140.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r140);

				Repository r141 = new Repository();
				r141.UserName = "FezVrasta";
				r141.RepositoryName = "bootstrap-material-design";
				r141.Description = "Material design theme for Bootstrap 3 and 4";
				r141.Tags = "";
				r141.URL = "https://github.com/FezVrasta/bootstrap-material-design";
				r141.LastUpdate = new DateTime(2017, 5, 9);
				r141.StarCount = 18.3m;
				r141.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r141);

				Repository r142 = new Repository();
				r142.UserName = "google";
				r142.RepositoryName = "protobuf";
				r142.Description = "Protocol Buffers - Google's data interchange format";
				r142.Tags = "protobuf-runtime,protocol-compiler,protobuf,protocol-buffers,serialization,marshalling,rpc,protoc";
				r142.URL = "https://github.com/google/protobuf";
				r142.LastUpdate = new DateTime(2017, 6, 24);
				r142.StarCount = 18.2m;
				r142.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r142);

				Repository r143 = new Repository();
				r143.UserName = "shadowsocks";
				r143.RepositoryName = "shadowsocks";
				r143.Description = "Updated Jun 24, 2017";
				r143.Tags = "";
				r143.URL = "https://github.com/shadowsocks/shadowsocks";
				r143.LastUpdate = new DateTime(2017, 6, 24);
				r143.StarCount = 18.2m;
				r143.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r143);

				Repository r144 = new Repository();
				r144.UserName = "emberjs";
				r144.RepositoryName = "ember.js";
				r144.Description = "Ember.js - A JavaScript framework for creating ambitious web applications";
				r144.Tags = "";
				r144.URL = "https://github.com/emberjs/ember.js";
				r144.LastUpdate = new DateTime(2017, 6, 24);
				r144.StarCount = 18m;
				r144.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r144);

				Repository r145 = new Repository();
				r145.UserName = "gohugoio";
				r145.RepositoryName = "hugo";
				r145.Description = "A Fast and Flexible Static Site Generator built with love in GoLang.";
				r145.Tags = "go,hugo,static-site-generator,cms,documentation-tool,blog-engine,content-management-system";
				r145.URL = "https://github.com/gohugoio/hugo";
				r145.LastUpdate = new DateTime(2017, 6, 24);
				r145.StarCount = 18m;
				r145.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r145);

				Repository r146 = new Repository();
				r146.UserName = "git";
				r146.RepositoryName = "git";
				r146.Description = "Git Source Code Mirror - This is a publish-only repository and all pull requests are ignored. Please follow Documenta";
				r146.Tags = "shell,c";
				r146.URL = "https://github.com/git/git";
				r146.LastUpdate = new DateTime(2017, 6, 24);
				r146.StarCount = 18m;
				r146.Language = db.Languages.FirstOrDefault(x => x.Name == "C");
				Repositories.Add(r146);

				Repository r147 = new Repository();
				r147.UserName = "rs";
				r147.RepositoryName = "SDWebImage";
				r147.Description = "Asynchronous image downloader with cache support as a UIImageView category";
				r147.Tags = "";
				r147.URL = "https://github.com/rs/SDWebImage";
				r147.LastUpdate = new DateTime(2017, 6, 23);
				r147.StarCount = 18m;
				r147.Language = db.Languages.FirstOrDefault(x => x.Name == "Objective-C");
				Repositories.Add(r147);

				Repository r148 = new Repository();
				r148.UserName = "Polymer";
				r148.RepositoryName = "polymer";
				r148.Description = "Build modern apps using web components";
				r148.Tags = "polymer,web-components";
				r148.URL = "https://github.com/Polymer/polymer";
				r148.LastUpdate = new DateTime(2017, 6, 23);
				r148.StarCount = 17.8m;
				r148.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r148);

				Repository r149 = new Repository();
				r149.UserName = "facebook";
				r149.RepositoryName = "pop";
				r149.Description = "An extensible iOS and OS X animation library, useful for physics-based interactions.";
				r149.Tags = "";
				r149.URL = "https://github.com/facebook/pop";
				r149.LastUpdate = new DateTime(2017, 6, 18);
				r149.StarCount = 17.8m;
				r149.Language = db.Languages.FirstOrDefault(x => x.Name == "Objective-C++");
				Repositories.Add(r149);

				Repository r150 = new Repository();
				r150.UserName = "zenorocha";
				r150.RepositoryName = "clipboard.js";
				r150.Description = " Modern copy to clipboard. No Flash. Just 3kb gzipped ";
				r150.Tags = "clipboard,javascript";
				r150.URL = "https://github.com/zenorocha/clipboard.js";
				r150.LastUpdate = new DateTime(2017, 6, 15);
				r150.StarCount = 17.8m;
				r150.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r150);

				Repository r151 = new Repository();
				r151.UserName = "tensorflow";
				r151.RepositoryName = "models";
				r151.Description = "Models built with TensorFlow";
				r151.Tags = "";
				r151.URL = "https://github.com/tensorflow/models";
				r151.LastUpdate = new DateTime(2017, 6, 23);
				r151.StarCount = 17.6m;
				r151.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r151);

				Repository r152 = new Repository();
				r152.UserName = "sindresorhus";
				r152.RepositoryName = "awesome-nodejs";
				r152.Description = " Delightful Node.js packages and resources";
				r152.Tags = "javascript,nodejs,list,awesome,node,awesome-list";
				r152.URL = "https://github.com/sindresorhus/awesome-nodejs";
				r152.LastUpdate = new DateTime(2017, 6, 23);
				r152.StarCount = 17.6m;
				r152.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r152);

				Repository r153 = new Repository();
				r153.UserName = "nvie";
				r153.RepositoryName = "gitflow";
				r153.Description = "Git extensions to provide high-level repository operations for Vincent Driessen's branching model.";
				r153.Tags = "";
				r153.URL = "https://github.com/nvie/gitflow";
				r153.LastUpdate = new DateTime(2017, 5, 12);
				r153.StarCount = 17.6m;
				r153.Language = db.Languages.FirstOrDefault(x => x.Name == "Shell");
				Repositories.Add(r153);

				Repository r154 = new Repository();
				r154.UserName = "zeit";
				r154.RepositoryName = "hyper";
				r154.Description = "A terminal built on web technologies";
				r154.Tags = "react,javascript,css,html,terminal,hyperterm,terminal-emulators";
				r154.URL = "https://github.com/zeit/hyper";
				r154.LastUpdate = new DateTime(2017, 6, 23);
				r154.StarCount = 17.5m;
				r154.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r154);

				Repository r155 = new Repository();
				r155.UserName = "donnemartin";
				r155.RepositoryName = "system-design-primer";
				r155.Description = "Learn how to design large-scale systems. Prep for the system design interview. Includes Anki flashcards.";
				r155.Tags = "interview-questions,python,design,development,programming,web,system,design-patterns,interview,web-application,webapp,interview-practice,design-system";
				r155.URL = "https://github.com/donnemartin/system-design-primer";
				r155.LastUpdate = new DateTime(2017, 6, 21);
				r155.StarCount = 17.5m;
				r155.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r155);

				Repository r156 = new Repository();
				r156.UserName = "vuejs";
				r156.RepositoryName = "awesome-vue";
				r156.Description = "A curated list of awesome things related to Vue.js";
				r156.Tags = "";
				r156.URL = "https://github.com/vuejs/awesome-vue";
				r156.LastUpdate = new DateTime(2017, 6, 23);
				r156.StarCount = 17.4m;
				r156.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r156);

				Repository r157 = new Repository();
				r157.UserName = "ReactiveCocoa";
				r157.RepositoryName = "ReactiveCocoa";
				r157.Description = "Streams of values over time";
				r157.Tags = "reactiveswift,swift,reactivecocoa";
				r157.URL = "https://github.com/ReactiveCocoa/ReactiveCocoa";
				r157.LastUpdate = new DateTime(2017, 6, 21);
				r157.StarCount = 17.4m;
				r157.Language = db.Languages.FirstOrDefault(x => x.Name == "Swift");
				Repositories.Add(r157);

				Repository r158 = new Repository();
				r158.UserName = "serverless";
				r158.RepositoryName = "serverless";
				r158.Description = "Serverless Framework  Build web, mobile and IoT applications with serverless architectures using AWS Lambda, Azure F";
				r158.Tags = "aws-lambda,serverless-framework,serverless-architectures,aws,serverless,azure-functions,google-cloud-functions,ibm-openwhisk";
				r158.URL = "https://github.com/serverless/serverless";
				r158.LastUpdate = new DateTime(2017, 6, 24);
				r158.StarCount = 17.3m;
				r158.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r158);

				Repository r159 = new Repository();
				r159.UserName = "balderdashy";
				r159.RepositoryName = "sails";
				r159.Description = "Realtime MVC Framework for Node.js";
				r159.Tags = "";
				r159.URL = "https://github.com/balderdashy/sails";
				r159.LastUpdate = new DateTime(2017, 6, 22);
				r159.StarCount = 17.3m;
				r159.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r159);

				Repository r160 = new Repository();
				r160.UserName = "plataformatec";
				r160.RepositoryName = "devise";
				r160.Description = "Flexible authentication solution for Rails with Warden.";
				r160.Tags = "rails,devise,ruby,plataformatec,authentication";
				r160.URL = "https://github.com/plataformatec/devise";
				r160.LastUpdate = new DateTime(2017, 6, 24);
				r160.StarCount = 17.2m;
				r160.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r160);

				Repository r161 = new Repository();
				r161.UserName = "kamranahmedse";
				r161.RepositoryName = "design-patterns-for-humans";
				r161.Description = "Design Patterns for Humans - An ultra-simplified explanation";
				r161.Tags = "";
				r161.URL = "https://github.com/kamranahmedse/design-patterns-for-humans";
				r161.LastUpdate = new DateTime(2017, 5, 16);
				r161.StarCount = 17.2m;
				r161.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r161);

				Repository r162 = new Repository();
				r162.UserName = "Prinzhorn";
				r162.RepositoryName = "skrollr";
				r162.Description = "Stand-alone parallax scrolling library for mobile (Android + iOS) and desktop. No jQuery. Just plain JavaScript (and ";
				r162.Tags = "";
				r162.URL = "https://github.com/Prinzhorn/skrollr";
				r162.LastUpdate = new DateTime(2016, 8, 10);
				r162.StarCount = 17.2m;
				r162.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r162);

				Repository r163 = new Repository();
				r163.UserName = "open-guides";
				r163.RepositoryName = "og-aws";
				r163.Description = " Amazon Web Services  a practical guide";
				r163.Tags = "";
				r163.URL = "https://github.com/open-guides/og-aws";
				r163.LastUpdate = new DateTime(2017, 6, 24);
				r163.StarCount = 17.1m;
				r163.Language = db.Languages.FirstOrDefault(x => x.Name == "Shell");
				Repositories.Add(r163);

				Repository r164 = new Repository();
				r164.UserName = "google";
				r164.RepositoryName = "guava";
				r164.Description = "Google Core Libraries for Java";
				r164.Tags = "";
				r164.URL = "https://github.com/google/guava";
				r164.LastUpdate = new DateTime(2017, 6, 23);
				r164.StarCount = 17.1m;
				r164.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r164);

				Repository r165 = new Repository();
				r165.UserName = "almasaeed2010";
				r165.RepositoryName = "AdminLTE";
				r165.Description = "AdminLTE - Free Premium Admin control Panel Theme Based On Bootstrap 3.x";
				r165.Tags = "";
				r165.URL = "https://github.com/almasaeed2010/AdminLTE";
				r165.LastUpdate = new DateTime(2017, 6, 24);
				r165.StarCount = 17m;
				r165.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r165);

				Repository r166 = new Repository();
				r166.UserName = "yahoo";
				r166.RepositoryName = "pure";
				r166.Description = "A set of small, responsive CSS modules that you can use in every web project.";
				r166.Tags = "html,css,pure";
				r166.URL = "https://github.com/yahoo/pure";
				r166.LastUpdate = new DateTime(2017, 6, 24);
				r166.StarCount = 17m;
				r166.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r166);

				Repository r167 = new Repository();
				r167.UserName = "herrbischoff";
				r167.RepositoryName = "awesome-osx-command-line";
				r167.Description = "Use your OS X terminal shell to do awesome things.";
				r167.Tags = "macos,shell,list,awesome,terminal,macosx,awesome-list";
				r167.URL = "https://github.com/herrbischoff/awesome-osx-command-line";
				r167.LastUpdate = new DateTime(2017, 6, 5);
				r167.StarCount = 17m;
				r167.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r167);

				Repository r168 = new Repository();
				r168.UserName = "numbbbbb";
				r168.RepositoryName = "the-swift-programming-language-in-chinese";
				r168.Description = " Apple  Swift The Swift Programming Language";
				r168.Tags = "";
				r168.URL = "https://github.com/numbbbbb/the-swift-programming-language-in-chinese";
				r168.LastUpdate = new DateTime(2017, 5, 31);
				r168.StarCount = 17m;
				r168.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r168);

				Repository r169 = new Repository();
				r169.UserName = "fchollet";
				r169.RepositoryName = "keras";
				r169.Description = "Deep Learning library for Python. Runs on TensorFlow, Theano, or CNTK.";
				r169.Tags = "theano,tensorflow,deep-learning,data-science,machine-learning,neural-networks";
				r169.URL = "https://github.com/fchollet/keras";
				r169.LastUpdate = new DateTime(2017, 6, 24);
				r169.StarCount = 16.9m;
				r169.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r169);

				Repository r170 = new Repository();
				r170.UserName = "mathiasbynens";
				r170.RepositoryName = "dotfiles";
				r170.Description = " .files, including ~/.macos  sensible hacker defaults for macOS";
				r170.Tags = "macos,dotfiles,bash";
				r170.URL = "https://github.com/mathiasbynens/dotfiles";
				r170.LastUpdate = new DateTime(2017, 6, 13);
				r170.StarCount = 16.9m;
				r170.Language = db.Languages.FirstOrDefault(x => x.Name == "Shell");
				Repositories.Add(r170);

				Repository r171 = new Repository();
				r171.UserName = "IanLunn";
				r171.RepositoryName = "Hover";
				r171.Description = "A collection of CSS3 powered hover effects to be applied to links, buttons, logos, SVG, featured images and so on. Ea";
				r171.Tags = "css,css-effects,sass";
				r171.URL = "https://github.com/IanLunn/Hover";
				r171.LastUpdate = new DateTime(2017, 4, 6);
				r171.StarCount = 16.9m;
				r171.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r171);

				Repository r172 = new Repository();
				r172.UserName = "hexojs";
				r172.RepositoryName = "hexo";
				r172.Description = "A fast, simple & powerful blog framework, powered by Node.js.";
				r172.Tags = "javascript,hexo,nodejs,static-site-generator";
				r172.URL = "https://github.com/hexojs/hexo";
				r172.LastUpdate = new DateTime(2017, 6, 22);
				r172.StarCount = 16.8m;
				r172.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r172);

				Repository r173 = new Repository();
				r173.UserName = "JakeWharton";
				r173.RepositoryName = "butterknife";
				r173.Description = "Bind Android views and callbacks to fields and methods.";
				r173.Tags = "";
				r173.URL = "https://github.com/JakeWharton/butterknife";
				r173.LastUpdate = new DateTime(2017, 6, 24);
				r173.StarCount = 16.7m;
				r173.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r173);

				Repository r174 = new Repository();
				r174.UserName = "videojs";
				r174.RepositoryName = "video.js";
				r174.Description = "Video.js - open source HTML5 & Flash video player";
				r174.Tags = "javascript,video,player,html,flash,html5,hls,html5-video,dash,videojs,html5-audio";
				r174.URL = "https://github.com/videojs/video.js";
				r174.LastUpdate = new DateTime(2017, 6, 23);
				r174.StarCount = 16.7m;
				r174.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r174);

				Repository r175 = new Repository();
				r175.UserName = "fastlane";
				r175.RepositoryName = "fastlane";
				r175.Description = " The easiest way to automate building and releasing your iOS and Android apps";
				r175.Tags = "fastlane,android,ios,screenshots,automation,mobile,deployment,apps";
				r175.URL = "https://github.com/fastlane/fastlane";
				r175.LastUpdate = new DateTime(2017, 6, 24);
				r175.StarCount = 16.6m;
				r175.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r175);

				Repository r176 = new Repository();
				r176.UserName = "google";
				r176.RepositoryName = "web-starter-kit";
				r176.Description = "Web Starter Kit - a workflow for multi-device websites";
				r176.Tags = "";
				r176.URL = "https://github.com/google/web-starter-kit";
				r176.LastUpdate = new DateTime(2017, 6, 8);
				r176.StarCount = 16.6m;
				r176.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r176);

				Repository r177 = new Repository();
				r177.UserName = "FallibleInc";
				r177.RepositoryName = "security-guide-for-developers";
				r177.Description = "Security Guide for Developers ()";
				r177.Tags = "security-checklist,security-book";
				r177.URL = "https://github.com/FallibleInc/security-guide-for-developers";
				r177.LastUpdate = new DateTime(2017, 3, 29);
				r177.StarCount = 16.6m;
				r177.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r177);

				Repository r178 = new Repository();
				r178.UserName = "grafana";
				r178.RepositoryName = "grafana";
				r178.Description = "The tool for beautiful monitoring and metric analytics & dashboards for Graphite, InfluxDB & Prometheus & More";
				r178.Tags = "elasticsearch,go,graphite,prometheus,grafana,influxdb,monitoring,analytics,metrics,alerting";
				r178.URL = "https://github.com/grafana/grafana";
				r178.LastUpdate = new DateTime(2017, 6, 24);
				r178.StarCount = 16.5m;
				r178.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r178);

				Repository r179 = new Repository();
				r179.UserName = "jgthms";
				r179.RepositoryName = "bulma";
				r179.Description = "Modern CSS framework based on Flexbox";
				r179.Tags = "flexbox,css,html,design,css-framework";
				r179.URL = "https://github.com/jgthms/bulma";
				r179.LastUpdate = new DateTime(2017, 6, 21);
				r179.StarCount = 16.5m;
				r179.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r179);

				Repository r180 = new Repository();
				r180.UserName = "astaxie";
				r180.RepositoryName = "build-web-application-with-golang";
				r180.Description = "A golang ebook intro how to build a web with golang";
				r180.Tags = "";
				r180.URL = "https://github.com/astaxie/build-web-application-with-golang";
				r180.LastUpdate = new DateTime(2017, 6, 19);
				r180.StarCount = 16.5m;
				r180.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r180);

				Repository r181 = new Repository();
				r181.UserName = "Reactive-Extensions";
				r181.RepositoryName = "RxJS";
				r181.Description = "The Reactive Extensions for JavaScript";
				r181.Tags = "";
				r181.URL = "https://github.com/Reactive-Extensions/RxJS";
				r181.LastUpdate = new DateTime(2017, 6, 15);
				r181.StarCount = 16.5m;
				r181.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r181);

				Repository r182 = new Repository();
				r182.UserName = "opencv";
				r182.RepositoryName = "opencv";
				r182.Description = "Open Source Computer Vision Library";
				r182.Tags = "opencv,c-plus-plus,computer-vision,deep-learning,image-processing";
				r182.URL = "https://github.com/opencv/opencv";
				r182.LastUpdate = new DateTime(2017, 6, 24);
				r182.StarCount = 16.4m;
				r182.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r182);

				Repository r183 = new Repository();
				r183.UserName = "PhilJay";
				r183.RepositoryName = "MPAndroidChart";
				r183.Description = "A powerful Android chart view / graph view library, supporting line- bar- pie- radar- bubble- and candlestick charts ";
				r183.Tags = "";
				r183.URL = "https://github.com/PhilJay/MPAndroidChart";
				r183.LastUpdate = new DateTime(2017, 6, 23);
				r183.StarCount = 16.4m;
				r183.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r183);

				Repository r184 = new Repository();
				r184.UserName = "hammerjs";
				r184.RepositoryName = "hammer.js";
				r184.Description = "A javascript library for multi-touch gestures :// You can touch this";
				r184.Tags = "";
				r184.URL = "https://github.com/hammerjs/hammer.js";
				r184.LastUpdate = new DateTime(2017, 6, 22);
				r184.StarCount = 16.4m;
				r184.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r184);

				Repository r185 = new Repository();
				r185.UserName = "syncthing";
				r185.RepositoryName = "syncthing";
				r185.Description = "Open Source Continuous File Synchronization";
				r185.Tags = "go,synchronization,peer-to-peer,p2p";
				r185.URL = "https://github.com/syncthing/syncthing";
				r185.LastUpdate = new DateTime(2017, 6, 21);
				r185.StarCount = 16.4m;
				r185.Language = db.Languages.FirstOrDefault(x => x.Name == "Go");
				Repositories.Add(r185);

				Repository r186 = new Repository();
				r186.UserName = "huginn";
				r186.RepositoryName = "huginn";
				r186.Description = "Create agents that monitor and act on your behalf. Your agents are standing by!";
				r186.Tags = "";
				r186.URL = "https://github.com/huginn/huginn";
				r186.LastUpdate = new DateTime(2017, 6, 15);
				r186.StarCount = 16.4m;
				r186.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r186);

				Repository r187 = new Repository();
				r187.UserName = "Kickball";
				r187.RepositoryName = "awesome-selfhosted";
				r187.Description = "This is a list of Free Software network services and web applications which can be hosted locally. Selfhosting is the";
				r187.Tags = "awesome,cloud,privacy,selfhosted,hosting,self-hosted,awesome-list";
				r187.URL = "https://github.com/Kickball/awesome-selfhosted";
				r187.LastUpdate = new DateTime(2017, 6, 23);
				r187.StarCount = 16.3m;
				r187.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r187);

				Repository r188 = new Repository();
				r188.UserName = "railsware";
				r188.RepositoryName = "upterm";
				r188.Description = "A terminal emulator for the 21st century.";
				r188.Tags = "console,terminal,tty,pty,terminal-emulators";
				r188.URL = "https://github.com/railsware/upterm";
				r188.LastUpdate = new DateTime(2017, 6, 20);
				r188.StarCount = 16.3m;
				r188.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r188);

				Repository r189 = new Repository();
				r189.UserName = "bumptech";
				r189.RepositoryName = "glide";
				r189.Description = "An image loading and caching library for Android focused on smooth scrolling";
				r189.Tags = "";
				r189.URL = "https://github.com/bumptech/glide";
				r189.LastUpdate = new DateTime(2017, 6, 24);
				r189.StarCount = 16.1m;
				r189.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r189);

				Repository r190 = new Repository();
				r190.UserName = "t4t5";
				r190.RepositoryName = "sweetalert";
				r190.Description = "A beautiful replacement for JavaScript's 'alert'";
				r190.Tags = "javascript,sweetalert,alert,ui,modal,dialog,popup";
				r190.URL = "https://github.com/t4t5/sweetalert";
				r190.LastUpdate = new DateTime(2017, 6, 21);
				r190.StarCount = 16.1m;
				r190.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r190);

				Repository r191 = new Repository();
				r191.UserName = "koajs";
				r191.RepositoryName = "koa";
				r191.Description = "Expressive middleware for node.js using ES2017 async functions";
				r191.Tags = "koa";
				r191.URL = "https://github.com/koajs/koa";
				r191.LastUpdate = new DateTime(2017, 6, 20);
				r191.StarCount = 16.1m;
				r191.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r191);

				Repository r192 = new Repository();
				r192.UserName = "bevacqua";
				r192.RepositoryName = "dragula";
				r192.Description = " Drag and drop so simple it hurts";
				r192.Tags = "javascript,front-end,component,vanilla,drag-and-drop,drag-drop,dragging";
				r192.URL = "https://github.com/bevacqua/dragula";
				r192.LastUpdate = new DateTime(2017, 6, 19);
				r192.StarCount = 16.1m;
				r192.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r192);

				Repository r193 = new Repository();
				r193.UserName = "ripienaar";
				r193.RepositoryName = "free-for-dev";
				r193.Description = "A list of SaaS, PaaS and IaaS offerings that have free tiers of interest to devops and infradev";
				r193.Tags = "";
				r193.URL = "https://github.com/ripienaar/free-for-dev";
				r193.LastUpdate = new DateTime(2017, 6, 20);
				r193.StarCount = 15.9m;
				r193.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r193);

				Repository r194 = new Repository();
				r194.UserName = "BradLarson";
				r194.RepositoryName = "GPUImage";
				r194.Description = "An open source iOS framework for GPU-based image and video processing";
				r194.Tags = "";
				r194.URL = "https://github.com/BradLarson/GPUImage";
				r194.LastUpdate = new DateTime(2017, 6, 14);
				r194.StarCount = 15.9m;
				r194.Language = db.Languages.FirstOrDefault(x => x.Name == "Objective-C");
				Repositories.Add(r194);

				Repository r195 = new Repository();
				r195.UserName = "request";
				r195.RepositoryName = "request";
				r195.Description = " Simplified HTTP request client.";
				r195.Tags = "";
				r195.URL = "https://github.com/request/request";
				r195.LastUpdate = new DateTime(2017, 6, 8);
				r195.StarCount = 15.9m;
				r195.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r195);

				Repository r196 = new Repository();
				r196.UserName = "sdmg15";
				r196.RepositoryName = "Best-websites-a-programmer-should-visit";
				r196.Description = " Some useful websites for programmers.";
				r196.Tags = "programmer,links,books,cs,sites";
				r196.URL = "https://github.com/sdmg15/Best-websites-a-programmer-should-visit";
				r196.LastUpdate = new DateTime(2017, 6, 24);
				r196.StarCount = 15.7m;
				r196.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r196);

				Repository r197 = new Repository();
				r197.UserName = "square";
				r197.RepositoryName = "leakcanary";
				r197.Description = "A memory leak detection library for Android and Java.";
				r197.Tags = "";
				r197.URL = "https://github.com/square/leakcanary";
				r197.LastUpdate = new DateTime(2017, 6, 23);
				r197.StarCount = 15.7m;
				r197.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r197);

				Repository r198 = new Repository();
				r198.UserName = "ziadoz";
				r198.RepositoryName = "awesome-php";
				r198.Description = "A curated list of amazingly awesome PHP libraries, resources and shiny things.";
				r198.Tags = "php-framework,php-installation,php-library,php-applications,php,php7,awesome-list";
				r198.URL = "https://github.com/ziadoz/awesome-php";
				r198.LastUpdate = new DateTime(2017, 6, 23);
				r198.StarCount = 15.7m;
				r198.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r198);

				Repository r199 = new Repository();
				r199.UserName = "aosabook";
				r199.RepositoryName = "500lines";
				r199.Description = "500 Lines or Less";
				r199.Tags = "";
				r199.URL = "https://github.com/aosabook/500lines";
				r199.LastUpdate = new DateTime(2017, 5, 30);
				r199.StarCount = 15.7m;
				r199.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r199);

				Repository r200 = new Repository();
				r200.UserName = "photonstorm";
				r200.RepositoryName = "phaser";
				r200.Description = "Phaser is a fun, free and fast 2D game framework for making HTML5 games for desktop and mobile web browsers, supporti";
				r200.Tags = "javascript,game-frameworks,webgl,phaser,game-development,phaserjs,html5-game-development";
				r200.URL = "https://github.com/photonstorm/phaser";
				r200.LastUpdate = new DateTime(2017, 6, 23);
				r200.StarCount = 15.6m;
				r200.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r200);

				Repository r201 = new Repository();
				r201.UserName = "angular";
				r201.RepositoryName = "material";
				r201.Description = "Material design for AngularJS";
				r201.Tags = "";
				r201.URL = "https://github.com/angular/material";
				r201.LastUpdate = new DateTime(2017, 6, 23);
				r201.StarCount = 15.6m;
				r201.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r201);

				Repository r202 = new Repository();
				r202.UserName = "GitbookIO";
				r202.RepositoryName = "gitbook";
				r202.Description = " Modern documentation format and toolchain using Git and Markdown";
				r202.Tags = "";
				r202.URL = "https://github.com/GitbookIO/gitbook";
				r202.LastUpdate = new DateTime(2017, 6, 3);
				r202.StarCount = 15.6m;
				r202.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r202);

				Repository r203 = new Repository();
				r203.UserName = "JetBrains";
				r203.RepositoryName = "kotlin";
				r203.Description = "The Kotlin Programming Language";
				r203.Tags = "kotlin,kotlin-library,programming-language,compiler,maven-plugin,gradle-plugin,intellij-plugin";
				r203.URL = "https://github.com/JetBrains/kotlin";
				r203.LastUpdate = new DateTime(2017, 6, 24);
				r203.StarCount = 15.5m;
				r203.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r203);

				Repository r204 = new Repository();
				r204.UserName = "SamyPesse";
				r204.RepositoryName = "How-to-Make-a-Computer-Operating-System";
				r204.Description = "How to Make a Computer Operating System in C++";
				r204.Tags = "";
				r204.URL = "https://github.com/SamyPesse/How-to-Make-a-Computer-Operating-System";
				r204.LastUpdate = new DateTime(2017, 6, 14);
				r204.StarCount = 15.5m;
				r204.Language = db.Languages.FirstOrDefault(x => x.Name == "C");
				Repositories.Add(r204);

				Repository r205 = new Repository();
				r205.UserName = "usablica";
				r205.RepositoryName = "intro.js";
				r205.Description = "A better way for new feature introduction and step-by-step users guide for your website and project.";
				r205.Tags = "javascript,html,introjs,ux,guide,tour";
				r205.URL = "https://github.com/usablica/intro.js";
				r205.LastUpdate = new DateTime(2017, 6, 24);
				r205.StarCount = 15.4m;
				r205.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r205);

				Repository r206 = new Repository();
				r206.UserName = "verekia";
				r206.RepositoryName = "js-stack-from-scratch";
				r206.Description = " Step-by-step tutorial to build a modern JavaScript stack.";
				r206.Tags = "tutorial,javascript,webpack,stack,react,yarn,flow,eslint,redux,heroku,bootstrap,react-router,jest,socket-io,nodemon,pm2,server-side-rendering,jss,immutablejs,sinon";
				r206.URL = "https://github.com/verekia/js-stack-from-scratch";
				r206.LastUpdate = new DateTime(2017, 6, 8);
				r206.StarCount = 15.4m;
				r206.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r206);

				Repository r207 = new Repository();
				r207.UserName = "nostra13";
				r207.RepositoryName = "Android-Universal-Image-Loader";
				r207.Description = "Powerful and flexible library for loading, caching and displaying images on Android.";
				r207.Tags = "";
				r207.URL = "https://github.com/nostra13/Android-Universal-Image-Loader";
				r207.LastUpdate = new DateTime(2017, 2, 3);
				r207.StarCount = 15.4m;
				r207.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r207);

				Repository r208 = new Repository();
				r208.UserName = "ZuzooVn";
				r208.RepositoryName = "machine-learning-for-software-engineers";
				r208.Description = "A complete daily plan for studying to become a machine learning engineer.";
				r208.Tags = "machine-learning,deep-learning,artificial-intelligence";
				r208.URL = "https://github.com/ZuzooVn/machine-learning-for-software-engineers";
				r208.LastUpdate = new DateTime(2017, 6, 14);
				r208.StarCount = 15.3m;
				r208.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r208);

				Repository r209 = new Repository();
				r209.UserName = "postcss";
				r209.RepositoryName = "postcss";
				r209.Description = "Transforming styles with JS plugins";
				r209.Tags = "css,parser,framework,postcss,ast";
				r209.URL = "https://github.com/postcss/postcss";
				r209.LastUpdate = new DateTime(2017, 6, 24);
				r209.StarCount = 15.2m;
				r209.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r209);

				Repository r210 = new Repository();
				r210.UserName = "ajaxorg";
				r210.RepositoryName = "ace";
				r210.Description = "Ace (Ajax.org Cloud9 Editor)";
				r210.Tags = "";
				r210.URL = "https://github.com/ajaxorg/ace";
				r210.LastUpdate = new DateTime(2017, 6, 22);
				r210.StarCount = 15.2m;
				r210.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r210);

				Repository r211 = new Repository();
				r211.UserName = "MaximAbramchuck";
				r211.RepositoryName = "awesome-interview-questions";
				r211.Description = "A curated awesome list of lists of interview questions. Feel free to contribute! ";
				r211.Tags = "rails-interview,python-interview-questions,javascript-interview-questions,angularjs-interview-questions,interview-questions,javascript,ruby,interviewing,list,awesome,awesomeness,awesome-list,interview-practice,android-interview-questions";
				r211.URL = "https://github.com/MaximAbramchuck/awesome-interview-questions";
				r211.LastUpdate = new DateTime(2017, 5, 2);
				r211.StarCount = 15.2m;
				r211.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r211);

				Repository r212 = new Repository();
				r212.UserName = "Tencent";
				r212.RepositoryName = "weui";
				r212.Description = "A UI library by WeChat official design team, includes the most useful widgets/modules in mobile web applications.";
				r212.Tags = "";
				r212.URL = "https://github.com/Tencent/weui";
				r212.LastUpdate = new DateTime(2017, 6, 22);
				r212.StarCount = 15.1m;
				r212.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r212);

				Repository r213 = new Repository();
				r213.UserName = "kahun";
				r213.RepositoryName = "awesome-sysadmin";
				r213.Description = "A curated list of amazingly awesome open source sysadmin resources inspired by Awesome PHP.";
				r213.Tags = "";
				r213.URL = "https://github.com/kahun/awesome-sysadmin";
				r213.LastUpdate = new DateTime(2017, 6, 14);
				r213.StarCount = 15.1m;
				r213.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r213);

				Repository r214 = new Repository();
				r214.UserName = "VundleVim";
				r214.RepositoryName = "Vundle.vim";
				r214.Description = "Vundle, the plug-in manager for Vim";
				r214.Tags = "";
				r214.URL = "https://github.com/VundleVim/Vundle.vim";
				r214.LastUpdate = new DateTime(2017, 6, 9);
				r214.StarCount = 15.1m;
				r214.Language = db.Languages.FirstOrDefault(x => x.Name == "Vim script");
				Repositories.Add(r214);

				Repository r215 = new Repository();
				r215.UserName = "bower";
				r215.RepositoryName = "bower";
				r215.Description = "A package manager for the web";
				r215.Tags = "javascript,bower,package-manager,front-end";
				r215.URL = "https://github.com/bower/bower";
				r215.LastUpdate = new DateTime(2017, 5, 30);
				r215.StarCount = 15.1m;
				r215.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r215);

				Repository r216 = new Repository();
				r216.UserName = "defunkt";
				r216.RepositoryName = "jquery-pjax";
				r216.Description = "pushState + ajax = pjax";
				r216.Tags = "";
				r216.URL = "https://github.com/defunkt/jquery-pjax";
				r216.LastUpdate = new DateTime(2017, 5, 23);
				r216.StarCount = 15.1m;
				r216.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r216);

				Repository r217 = new Repository();
				r217.UserName = "SnapKit";
				r217.RepositoryName = "Masonry";
				r217.Description = "Harness the power of AutoLayout NSLayoutConstraints with a simplified, chainable and expressive syntax. Supports iOS ";
				r217.Tags = "";
				r217.URL = "https://github.com/SnapKit/Masonry";
				r217.LastUpdate = new DateTime(2017, 6, 15);
				r217.StarCount = 15m;
				r217.Language = db.Languages.FirstOrDefault(x => x.Name == "Objective-C");
				Repositories.Add(r217);

				Repository r218 = new Repository();
				r218.UserName = "pixijs";
				r218.RepositoryName = "pixi.js";
				r218.Description = "Super fast HTML 5 2D rendering engine that uses webGL with canvas fallback";
				r218.Tags = "game,javascript,pixi,canvas,webgl,canvas2d,pixijs,glsl,rendering,renderer,rendering-engine,rendering-2d-graphics";
				r218.URL = "https://github.com/pixijs/pixi.js";
				r218.LastUpdate = new DateTime(2017, 6, 22);
				r218.StarCount = 14.9m;
				r218.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r218);

				Repository r219 = new Repository();
				r219.UserName = "greenrobot";
				r219.RepositoryName = "EventBus";
				r219.Description = "Android optimized event bus that simplifies communication between Activities, Fragments, Threads, Services, etc. Less";
				r219.Tags = "";
				r219.URL = "https://github.com/greenrobot/EventBus";
				r219.LastUpdate = new DateTime(2017, 6, 19);
				r219.StarCount = 14.9m;
				r219.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r219);

				Repository r220 = new Repository();
				r220.UserName = "danielgindi";
				r220.RepositoryName = "Charts";
				r220.Description = "Beautiful charts for iOS/tvOS/OSX! The Apple side of the crossplatform MPAndroidChart.";
				r220.Tags = "";
				r220.URL = "https://github.com/danielgindi/Charts";
				r220.LastUpdate = new DateTime(2017, 6, 19);
				r220.StarCount = 14.9m;
				r220.Language = db.Languages.FirstOrDefault(x => x.Name == "Swift");
				Repositories.Add(r220);

				Repository r221 = new Repository();
				r221.UserName = "XX-net";
				r221.RepositoryName = "XX-Net";
				r221.Description = "a web proxy tool";
				r221.Tags = "xx-net,goagent,gfw";
				r221.URL = "https://github.com/XX-net/XX-Net";
				r221.LastUpdate = new DateTime(2017, 6, 17);
				r221.StarCount = 14.9m;
				r221.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r221);

				Repository r222 = new Repository();
				r222.UserName = "mitchellh";
				r222.RepositoryName = "vagrant";
				r222.Description = "Vagrant is a tool for building and distributing development environments.";
				r222.Tags = "";
				r222.URL = "https://github.com/mitchellh/vagrant";
				r222.LastUpdate = new DateTime(2017, 6, 23);
				r222.StarCount = 14.8m;
				r222.Language = db.Languages.FirstOrDefault(x => x.Name == "Ruby");
				Repositories.Add(r222);

				Repository r223 = new Repository();
				r223.UserName = "petkaantonov";
				r223.RepositoryName = "bluebird";
				r223.Description = "  Bluebird is a full featured promise library with unmatched performance.";
				r223.Tags = "";
				r223.URL = "https://github.com/petkaantonov/bluebird";
				r223.LastUpdate = new DateTime(2017, 6, 23);
				r223.StarCount = 14.8m;
				r223.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r223);

				Repository r224 = new Repository();
				r224.UserName = "ftlabs";
				r224.RepositoryName = "fastclick";
				r224.Description = "Polyfill to remove click delays on browsers with touch UIs";
				r224.Tags = "";
				r224.URL = "https://github.com/ftlabs/fastclick";
				r224.LastUpdate = new DateTime(2017, 6, 13);
				r224.StarCount = 14.8m;
				r224.Language = db.Languages.FirstOrDefault(x => x.Name == "HTML");
				Repositories.Add(r224);

				Repository r225 = new Repository();
				r225.UserName = "less";
				r225.RepositoryName = "less.js";
				r225.Description = "Less. The dynamic stylesheet language.";
				r225.Tags = "";
				r225.URL = "https://github.com/less/less.js";
				r225.LastUpdate = new DateTime(2017, 6, 8);
				r225.StarCount = 14.8m;
				r225.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r225);

				Repository r226 = new Repository();
				r226.UserName = "SwiftyJSON";
				r226.RepositoryName = "SwiftyJSON";
				r226.Description = "The better way to deal with JSON data in Swift";
				r226.Tags = "swiftyjson,json";
				r226.URL = "https://github.com/SwiftyJSON/SwiftyJSON";
				r226.LastUpdate = new DateTime(2017, 6, 4);
				r226.StarCount = 14.8m;
				r226.Language = db.Languages.FirstOrDefault(x => x.Name == "Swift");
				Repositories.Add(r226);

				Repository r227 = new Repository();
				r227.UserName = "symfony";
				r227.RepositoryName = "symfony";
				r227.Description = "The Symfony PHP framework";
				r227.Tags = "php-framework,php,symfony,framework,bundle,symfony-bundle,psr-11,psr-3,psr-6,psr-16,psr-13";
				r227.URL = "https://github.com/symfony/symfony";
				r227.LastUpdate = new DateTime(2017, 6, 24);
				r227.StarCount = 14.7m;
				r227.Language = db.Languages.FirstOrDefault(x => x.Name == "PHP");
				Repositories.Add(r227);

				Repository r228 = new Repository();
				r228.UserName = "ant-design";
				r228.RepositoryName = "ant-design";
				r228.Description = " A UI Design Language";
				r228.Tags = "enterprise,antd,typescript,css,react,ui-design,design-systems,frontend,react-components,ui-kit,ant-design";
				r228.URL = "https://github.com/ant-design/ant-design";
				r228.LastUpdate = new DateTime(2017, 6, 24);
				r228.StarCount = 14.7m;
				r228.Language = db.Languages.FirstOrDefault(x => x.Name == "TypeScript");
				Repositories.Add(r228);

				Repository r229 = new Repository();
				r229.UserName = "ApacheInfra";
				r229.RepositoryName = "superset";
				r229.Description = "Apache Superset (incubating) is a modern, enterprise-ready business intelligence web application";
				r229.Tags = "druid,data,data-visualization,dashboards,data-analysis,sql-editor";
				r229.URL = "https://github.com/ApacheInfra/superset";
				r229.LastUpdate = new DateTime(2017, 6, 24);
				r229.StarCount = 14.7m;
				r229.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r229);

				Repository r230 = new Repository();
				r230.UserName = "lord";
				r230.RepositoryName = "slate";
				r230.Description = "Beautiful static documentation for your API";
				r230.Tags = "slate,api,static-site-generator,api-documentation";
				r230.URL = "https://github.com/lord/slate";
				r230.LastUpdate = new DateTime(2017, 6, 22);
				r230.StarCount = 14.7m;
				r230.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r230);

				Repository r231 = new Repository();
				r231.UserName = "github";
				r231.RepositoryName = "fetch";
				r231.Description = "A window.fetch JavaScript polyfill.";
				r231.Tags = "javascript,polyfill,fetch,promise";
				r231.URL = "https://github.com/github/fetch";
				r231.LastUpdate = new DateTime(2017, 6, 19);
				r231.StarCount = 14.7m;
				r231.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r231);

				Repository r232 = new Repository();
				r232.UserName = "ryanmcdermott";
				r232.RepositoryName = "clean-code-javascript";
				r232.Description = " Clean Code concepts adapted for JavaScript";
				r232.Tags = "inheritance,javascript,principles,composition,best-practices,clean-code,clean-architecture";
				r232.URL = "https://github.com/ryanmcdermott/clean-code-javascript";
				r232.LastUpdate = new DateTime(2017, 6, 15);
				r232.StarCount = 14.7m;
				r232.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r232);

				Repository r233 = new Repository();
				r233.UserName = "facebook";
				r233.RepositoryName = "hhvm";
				r233.Description = "A virtual machine designed for executing programs written in Hack and PHP.";
				r233.Tags = "hhvm,hack,php,hacklang";
				r233.URL = "https://github.com/facebook/hhvm";
				r233.LastUpdate = new DateTime(2017, 6, 24);
				r233.StarCount = 14.6m;
				r233.Language = db.Languages.FirstOrDefault(x => x.Name == "C++");
				Repositories.Add(r233);

				Repository r234 = new Repository();
				r234.UserName = "spring-projects";
				r234.RepositoryName = "spring-framework";
				r234.Description = "The Spring Framework";
				r234.Tags = "";
				r234.URL = "https://github.com/spring-projects/spring-framework";
				r234.LastUpdate = new DateTime(2017, 6, 23);
				r234.StarCount = 14.6m;
				r234.Language = db.Languages.FirstOrDefault(x => x.Name == "Java");
				Repositories.Add(r234);

				Repository r235 = new Repository();
				r235.UserName = "bcit-ci";
				r235.RepositoryName = "CodeIgniter";
				r235.Description = "Open Source PHP Framework (originally from EllisLab)";
				r235.Tags = "php";
				r235.URL = "https://github.com/bcit-ci/CodeIgniter";
				r235.LastUpdate = new DateTime(2017, 6, 22);
				r235.StarCount = 14.6m;
				r235.Language = db.Languages.FirstOrDefault(x => x.Name == "PHP");
				Repositories.Add(r235);

				Repository r236 = new Repository();
				r236.UserName = "pugjs";
				r236.RepositoryName = "pug";
				r236.Description = "Pug  robust, elegant, feature rich template engine for Node.js";
				r236.Tags = "";
				r236.URL = "https://github.com/pugjs/pug";
				r236.LastUpdate = new DateTime(2017, 6, 20);
				r236.StarCount = 14.6m;
				r236.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r236);

				Repository r237 = new Repository();
				r237.UserName = "alex";
				r237.RepositoryName = "what-happens-when";
				r237.Description = "An attempt to answer the age old interview question 'What happens when you type google.com into your browser and pres";
				r237.Tags = "";
				r237.URL = "https://github.com/alex/what-happens-when";
				r237.LastUpdate = new DateTime(2017, 4, 20);
				r237.StarCount = 14.6m;
				r237.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r237);

				Repository r238 = new Repository();
				r238.UserName = "0xAX";
				r238.RepositoryName = "linux-insides";
				r238.Description = "A little bit about a linux kernel";
				r238.Tags = "linux-kernel,linux-insides,linux";
				r238.URL = "https://github.com/0xAX/linux-insides";
				r238.LastUpdate = new DateTime(2017, 6, 20);
				r238.StarCount = 14.5m;
				r238.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r238);

				Repository r239 = new Repository();
				r239.UserName = "zeit";
				r239.RepositoryName = "next.js";
				r239.Description = "Framework for server-rendered React apps";
				r239.Tags = "react,components,node,browser,universal,nextjs,server-rendering";
				r239.URL = "https://github.com/zeit/next.js";
				r239.LastUpdate = new DateTime(2017, 6, 24);
				r239.StarCount = 14.4m;
				r239.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r239);

				Repository r240 = new Repository();
				r240.UserName = "kriasoft";
				r240.RepositoryName = "react-starter-kit";
				r240.Description = "React Starter Kit  isomorphic web app boilerplate (Node.js, Express, GraphQL, React.js, Babel, PostCSS, Webpack, Bro";
				r240.Tags = "babel,webpack,graphql,browsersync,javascript,flux,boilerplate,react,redux,nodejs,i18n,ssr,reactjs";
				r240.URL = "https://github.com/kriasoft/react-starter-kit";
				r240.LastUpdate = new DateTime(2017, 6, 21);
				r240.StarCount = 14.4m;
				r240.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r240);

				Repository r241 = new Repository();
				r241.UserName = "alibaba";
				r241.RepositoryName = "weex";
				r241.Description = "A framework for building Mobile cross-platform UI";
				r241.Tags = "weex,android,ios,mobile,sdk,web";
				r241.URL = "https://github.com/alibaba/weex";
				r241.LastUpdate = new DateTime(2017, 6, 19);
				r241.StarCount = 14.4m;
				r241.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r241);

				Repository r242 = new Repository();
				r242.UserName = "react-boilerplate";
				r242.RepositoryName = "react-boilerplate";
				r242.Description = " A highly scalable, offline-first foundation with the best developer experience and a focus on performance and best";
				r242.Tags = "react,redux,i18n,styled-components,redux-saga,offline-first,react-boilerplate,webpack2,scaffolding";
				r242.URL = "https://github.com/react-boilerplate/react-boilerplate";
				r242.LastUpdate = new DateTime(2017, 6, 24);
				r242.StarCount = 14.3m;
				r242.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r242);

				Repository r243 = new Repository();
				r243.UserName = "tonsky";
				r243.RepositoryName = "FiraCode";
				r243.Description = "Monospaced font with programming ligatures";
				r243.Tags = "ligatures,programming-ligatures,font";
				r243.URL = "https://github.com/tonsky/FiraCode";
				r243.LastUpdate = new DateTime(2017, 6, 22);
				r243.StarCount = 14.3m;
				r243.Language = db.Languages.FirstOrDefault(x => x.Name == "Clojure");
				Repositories.Add(r243);

				Repository r244 = new Repository();
				r244.UserName = "twitter";
				r244.RepositoryName = "typeahead.js";
				r244.Description = "typeahead.js is a fast and fully-featured autocomplete library";
				r244.Tags = "";
				r244.URL = "https://github.com/twitter/typeahead.js";
				r244.LastUpdate = new DateTime(2017, 5, 1);
				r244.StarCount = 14.3m;
				r244.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r244);

				Repository r245 = new Repository();
				r245.UserName = "FreeCodeCampChina";
				r245.RepositoryName = "freecodecamp.cn";
				r245.Description = "CodeIssuesPull requestsWiki^_^";
				r245.Tags = "";
				r245.URL = "https://github.com/FreeCodeCampChina/freecodecamp.cn";
				r245.LastUpdate = new DateTime(2017, 6, 22);
				r245.StarCount = 14.2m;
				r245.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r245);

				Repository r246 = new Repository();
				r246.UserName = "dimsemenov";
				r246.RepositoryName = "PhotoSwipe";
				r246.Description = "JavaScript image gallery for mobile and desktop, modular, framework independent";
				r246.Tags = "";
				r246.URL = "https://github.com/dimsemenov/PhotoSwipe";
				r246.LastUpdate = new DateTime(2017, 6, 20);
				r246.StarCount = 14.2m;
				r246.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r246);

				Repository r247 = new Repository();
				r247.UserName = "angular-ui";
				r247.RepositoryName = "bootstrap-angular";
				r247.Description = "Native AngularJS (Angular) directives for Bootstrap. Smaller footprint (20kB gzipped), no 3rd party JS dependencies (";
				r247.Tags = "";
				r247.URL = "https://github.com/angular-ui/bootstrap";
				r247.LastUpdate = new DateTime(2017, 6, 19);
				r247.StarCount = 14.2m;
				r247.Language = db.Languages.FirstOrDefault(x => x.Name == "JavaScript");
				Repositories.Add(r247);

				Repository r248 = new Repository();
				r248.UserName = "dhg";
				r248.RepositoryName = "Skeleton";
				r248.Description = "Skeleton: A Dead Simple, Responsive Boilerplate for Mobile-Friendly Development";
				r248.Tags = "";
				r248.URL = "https://github.com/dhg/Skeleton";
				r248.LastUpdate = new DateTime(2017, 5, 17);
				r248.StarCount = 14.2m;
				r248.Language = db.Languages.FirstOrDefault(x => x.Name == "CSS");
				Repositories.Add(r248);

				Repository r249 = new Repository();
				r249.UserName = "Valloric";
				r249.RepositoryName = "YouCompleteMe";
				r249.Description = "A code-completion engine for Vim";
				r249.Tags = "semantic-engine,vim,code-analysis,code-completion";
				r249.URL = "https://github.com/Valloric/YouCompleteMe";
				r249.LastUpdate = new DateTime(2017, 6, 21);
				r249.StarCount = 14.1m;
				r249.Language = db.Languages.FirstOrDefault(x => x.Name == "Python");
				Repositories.Add(r249);

				Repository r250 = new Repository();
				r250.UserName = "futurice";
				r250.RepositoryName = "android-best-practices";
				r250.Description = "Do's and Don'ts for Android development, by Futurice developers";
				r250.Tags = "best-practices";
				r250.URL = "https://github.com/futurice/android-best-practices";
				r250.LastUpdate = new DateTime(2017, 6, 17);
				r250.StarCount = 14.1m;
				r250.Language = db.Languages.FirstOrDefault(x => x.Name == "Unspecified");
				Repositories.Add(r250);

				//loop through repos
				foreach (Repository repo in Repositories)
				{
					//set name of repo to help debug
					repoName = repo.RepositoryName;

					//see if repo exists in database
					Repository dbRepo = db.Repositories.FirstOrDefault(r => r.RepositoryName == repo.RepositoryName);

					if (dbRepo == null) //repository does not exist in database
					{
						db.Repositories.Add(repo);
						db.SaveChanges();
						intReposAdded += 1;
					}
					else
					{
						dbRepo.Description = repo.Description;
						dbRepo.Language = db.Languages.FirstOrDefault(l => l.LanguageID == repo.Language.LanguageID);
						dbRepo.LastUpdate = repo.LastUpdate;
						dbRepo.RepositoryName = repo.RepositoryName;
						dbRepo.StarCount = repo.StarCount;
						dbRepo.Tags = repo.Tags;
						dbRepo.URL = repo.URL;
						dbRepo.UserName = repo.UserName;
						db.Update(dbRepo);
						db.SaveChanges();
					}
				}
			}
			catch
			{
				String msg = "Repositories added:" + intReposAdded + "; Error on " + repoName;
				throw new InvalidOperationException(msg);
			}
		}
	}
}
