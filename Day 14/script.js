document.addEventListener('DOMContentLoaded', () => {
    console.log('Portfolio loaded successfully!');
  
    // Add smooth scroll to section links (if any are included in the navbar later)
    const links = document.querySelectorAll('a[href^="#"]');
  
    links.forEach(link => {
      link.addEventListener('click', (e) => {
        e.preventDefault();
        const targetId = link.getAttribute('href').substring(1);
        const targetSection = document.getElementById(targetId);
        if (targetSection) {
          window.scrollTo({
            top: targetSection.offsetTop,
            behavior: 'smooth'
          });
        }
      });
    });
    document.querySelectorAll('.btn').forEach(button => {
        button.addEventListener('click', function(event) {
          event.preventDefault();
          window.open(this.href, '_blank', 'width=800,height=600');
        });
      });
      
    // Add any other JavaScript functionality here, like animations or dynamic updates.
  });
  