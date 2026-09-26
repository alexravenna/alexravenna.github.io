---
title: 'Adding MarkdownSnippets'
published: 2026-09-22
draft: true
description: 'How I added MarkdownSnippets to this website.'
tags: ['markdown', 'snippets', 'mdsnippets', 'astro', 'dotnet']
---

## The Issue

Since this is a more technical blog, I will be including code snippets in a lot of my posts.

The author of the code behind this blog, [stelcodes](https://github.com/stelcodes/multiterm-astro), graciously made it possible to use Markdown code blocks with syntax highlighting, like so:

```csharp
public class MyClass {
    private readonly string _name;

    public MyClass(string name) {
        _name = name;
    }
}
```

That's made possible through [Expressive Code](https://expressive-code.com) and its plugin for Astro, [astro-expressive-code](https://github.com/expressive-code/expressive-code/blob/main/packages/astro-expressive-code/README.md), and that does look really good! You can even configure additional options, like adding line numbers, highlighting specific lines, etc.

However, while writing code in a Markdown file is simple, that simplicity has some downsides:

- you don't know immediately if the code would actually compile or if you made a syntax error somewhere
- manual formatting (e.g. indents) can be a pain
- you can't easily re-use that snippet anywhere else

## The Solution

As I work with .NET technologies (that is, mostly C# and associated frameworks) in my daily job, I spend a good amount of time poring through documentation and blog posts for various frameworks and libraries. On some of those sites I noticed snippets like this:

[Source]()

Simon Cropp is a prolific author of tools in the .NET scene, just see his [GitHub profile](https://github.com/SimonCropp). He's also mentioned regularly in the segment "Better Know a Framework" on the [Dotnet Rocks podcast](https://www.dotnetrocks.com), one of my favorite podcasts about .NET and software development in general.

## Adding Markdown Snippets

### Enabling Development

I typically edit this blog in a [Devcontainer](link) so that I don't need to have Node.js and a package manager (npm/pnpm/yarn) always installed on whichever machine I'm currently on - or maybe I'm even using a [Codespace](link), which use can use Devcontainer configurations out-of-the-box!

Anyway, that means I needed .NET to be available in the Devcontainer so I could start the blog with MarkdownSnippets during development.

### To the Blog

### To GitHub Actions

Since the GitHub Action for building and deploying this site was only designed for building the Astro site, I had to add .NET to the mix in order for the Markdown snippets to actually be transformed during the website build.

## Resources

- [MarkdownSnippets GitHub repo](https://github.com/SimonCropp/MarkdownSnippets)

- [Great .NET Documentation with Astro, Starlight, and MarkdownSnippets](https://khalidabuhakmeh.com/posts/great-dotnet-documentation-with-astro-starlight-and-markdownsnippets/)
