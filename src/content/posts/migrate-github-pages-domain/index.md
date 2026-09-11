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

Here's the original redirect configured in my domain provider:

![Permanent domain redirect configuration from alexravenna.com to https://alexravenna.is-a.dev](redirect-configuration.png)

If this were active, this would mean that inputting "alexravenna.com" into your browser, would always automatically take you to "https://alexravenna.is-a.dev" without you having to do anything.

## Migrating Domains

When this post goes live, you should always be redirected to this final URL

```
http://alexravenna.com/posts/migrate-github-pages-domain
```

and not to

```
http://alexravenna.is-a.dev/posts/migrate-github-pages-domain
```

How did I achieve that?

1. First, I removed the redirect configuration from my domain provider (see the screenshot above). They informed me:
![A notice from the domain provider stating "The redirect usually takes 1 hour to work. Sometimes, it can take up to 48 hours."](redirect-deletion-notice.png)

2. Next, I updated the GitHub Pages setting for the code repository. That's where you have to tell GitHub that you're using a custom domain instead of the default <GITHUB-USERNAME>-github.io domain.
The previous configuration for the alexravenna.is-a.dev custom domain looked like this:
![GitHub Pages domain configuration for alexravenna.is-a.dev](github-pages-configuration-orig.png)
I changed it to be:
![GitHub Pages domain configuration for alexravenna.is-a.dev](github-pages-configuration-new.png)
GitHub does a DNS check after you save to make sure the new doman can be resolved.

## Resources:

- [GitHub Pages documentation](https://docs.github.com/en/pages)
  - [About custom domains and GitHub Pages](https://docs.github.com/en/pages/configuring-a-custom-domain-for-your-github-pages-site/about-custom-domains-and-github-pages)
- [is-a.dev](https://is-a.dev)