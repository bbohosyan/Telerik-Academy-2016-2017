function solve() {
	return function() {
		var template = [
			'<h1>{{title}}</h1>',
'<ul>',
		'{{#posts}}',
				'<li>',
			'<div class="post">',
				'<p class="author">',
				'{{#if author}}',
												'<a class="user" href="/user/{{author}}">{{this.author}}</a>',
						'{{else}}',
						'<a class="anonymous">Anonymous</a>',
						'{{/if}}',
				'</p>',
				'<pre class="content">{{{this.text}}}</pre>',
			'</div>',
			'<ul>',
			'{{#comments}}',
			'{{#unless deleted}}',
						'<li>',
							'<div class="comment">',
								'<p class="author">',
														'{{#if author}}',
												'<a class="user" href="/user/{{this.author}}">{{this.author}}</a>',
						'{{else}}',
						'<a class="anonymous">Anonymous</a>',
						'{{/if}}',
								'</p>',
								'<pre class="content">{{this.text}}</pre>',
							'</div>',
						'</li>',
						'{{/unless}}',
						'{{/comments}}',
			'</ul>',
		'</li>',
		'{{/posts}}',
          
          '</ul>',

		].join('\n');

		return template;
	}
}