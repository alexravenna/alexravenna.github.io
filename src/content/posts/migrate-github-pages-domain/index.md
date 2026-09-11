---
title: 'Migrating the Domain for GitHub Pages'
published: 2026-09-11
draft: true
description: 'How to change the domain of your GitHub Pages website.'
tags: ['github', 'github-pages', 'domain', 'dns', 'cname']
---

## Introduction

I recently decided to switch to alexravenna.com as the canonical domain for my website.

I already own the domain (woohoo!), but for some reason had originally decided to have alexravenna.is-a.dev be the default domain for this site.

## Terminology

First, let's take a quick refresher on the terms behind a URL like https://alexravenna.github.io to avoid confusion later:

|URL Section|Term|
|-|-|
|https|scheme|
|alexravenna|subdomain label|
|alexravenna.github.io|subdomain|
|github.io|apex domain|
|io|top-level domain (TLD)|

## GitHub Pages Default Domain Name

This website is hosted on [GitHub Pages](https://docs.github.com/en/pages), which automatically gives it the domain [alexravenna.github.io](https://alexravenna.github.io). That domain comes from my GitHub username, "alexravenna".

As described in [the documentation](https://docs.github.com/en/pages/getting-started-with-github-pages/what-is-github-pages#types-of-github-pages-sites), the code for a website hosted on GitHub Pages has to be located in a repository of the name

```
<GITHUB-USERNAME>.github.io
```

for example: [alexravenna.github.io](https://github.com/alexravenna/alexravenna.github.io) (click to be taken to the repository). You can only create one such GitHub Pages website per GitHub username.

I thought that alexravenna.github.io was too boring, so I decided I'd rather use a custom domain!

## Custom .is-a.dev Subdomain

I stumbled upon the [is-a.dev project](https://is-a.dev) at some point, which allows anyone to create a custom subdomain under the "is-a.dev" apex domain for free. Since I'm a software **dev**eloper, that appealed to me!

That means that if you follow the [registration process for GitHub Pages ](https://docs.is-a.dev/guides/github-pages/) - maybe I'll make a post about that someday, since it was more complicated than I expected - you receive a free domain at 

```
<GITHUB-USERNAME>.is-a.dev
```

However, in order to make "alexravenna.is-a.dev" be the final destination for "alexravenna.com" too, it was necessary to configure a redirect.

## Original Redirect

Here's the current redirect configuration in my domain provider:
![Permanent domain redirect configuration from alexravenna.com to https://alexravenna.is-a.dev](redirect-configuration.png)

This means that if you input "alexravenna.com" into your browser, your browser will always automatically take you to "https://alexravenna.is-a.dev" without you having to do anything.

## Migrating Domains

When this post goes live, you should always find it at this final URL

```
http://alexravenna.com/posts/migrate-github-pages-domain
```

and not at 

```
http://alexravenna.is-a.dev/posts/migrate-github-pages-domain
```

How did I achieve that?

## Resources:

- [GitHub Pages documentation](https://docs.github.com/en/pages)
  - [About custom domains and GitHub Pages](https://docs.github.com/en/pages/configuring-a-custom-domain-for-your-github-pages-site/about-custom-domains-and-github-pages)
- [is-a.dev](https://is-a.dev)