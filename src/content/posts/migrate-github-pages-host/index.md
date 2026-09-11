---
title: 'Migrating the host for GitHub Pages'
published: 2026-09-11
draft: true
description: 'How to change the hostname of your GitHub Pages website.'
tags: ['github', 'github-pages', 'dns', 'cname', 'host']
---

I recently decided to use switch to alexravenna.com as the canonical domain for my website.

I already own the domain (woohoo!), but for some reason had originally decided to have alexravenna.is-a.dev be the default domain for this site.

# GitHub Pages Default Domain

This website is hosted on [GitHub Pages](https://docs.github.com/en/pages), which automatically gives it the URL [alexravenna.github.io](https://alexravenna.github.io) - this comes from the name of the code repository behind it, [alexravenna.github.io](https://github.com/alexravenna/alexravenna.github.io) (click to be taken to the repository).

I thought that was too boring, so I decided I'd rather use a custom domain!

# Custom .is-a.dev Subdomain

[CNAME file](https://github.com/alexravenna/alexravenna.github.io/blob/main/CNAME)

This makes it so that 

In order to make alexravenna.is-a.dev be the final destination for alexravenna.com too, it was necessary to configure a redirect.

# Original Redirect

Here's the current redirect configuration in my domain provider:
![Permanent domain redirect configuration from alexravenna.com to https://alexravenna.is-a.dev](redirect-configuration.png)

This means that if you input "alexravenna.com" into your browser, your browser will always automatically take you to "https://alexravenna.is-a.dev" without you having to do anything.

# Migrating 

When this post goes live, you should

# Resources:

- [GitHub Pages documentation](https://docs.github.com/en/pages)
  - [About custom domains and GitHub Pages](https://docs.github.com/en/pages/configuring-a-custom-domain-for-your-github-pages-site/about-custom-domains-and-github-pages)
- [is-a.dev](https://is-a.dev)