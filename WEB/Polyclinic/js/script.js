$('[data-open-block').on('click', function() {
  const activeCls = 'is-active';

  $('[data-content]').removeClass(activeCls);
  $(`[data-content="${$(this).data('open-block')}"`).addClass(activeCls);
});
