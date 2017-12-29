<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View_Main.ascx.cs" Inherits="Adam.View_Main" %>


    <base href="/DesktopModules/Adam/src/">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="/DesktopModules/Adam/src/styles.css">
    <!-- Polyfill(s) for older browsers -->
    <script src="/DesktopModules/Adam/node_modules/core-js/client/shim.min.js"></script>
    <script src="/DesktopModules/Adam/node_modules/zone.js/dist/zone.js"></script>
    <script src="/DesktopModules/Adam/node_modules/systemjs/dist/system.src.js"></script>
    <script src="/DesktopModules/Adam/src/systemjs.config.js"></script>
    <script>
      System.import('main.js').catch(function(err){ console.error(err); });
    </script>

    <app-root>Loading AppComponent content here ...</app-root>
