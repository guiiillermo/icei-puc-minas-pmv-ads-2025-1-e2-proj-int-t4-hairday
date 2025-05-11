document.addEventListener("DOMContentLoaded", function () {
    // Configurações do Observer para fade-in
    const fadeObserver = new IntersectionObserver((entries, observer) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('fade-in');
                observer.unobserve(entry.target);
            }
        });
    }, {
        threshold: 0.1,
        rootMargin: '0px 0px -100px 0px'
    });

    // Observar todos os elementos com fade
    document.querySelectorAll('.fade-item').forEach(item => {
        fadeObserver.observe(item);
    });

    // Efeito hover para botão de barbearia
    const barbeariaBtn = document.getElementById('cadastroBarbeariaId');
    if (barbeariaBtn) {
        barbeariaBtn.addEventListener('mouseenter', function () {
            this.style.backgroundColor = '#725AC1';
            this.style.color = 'white';
        });

        barbeariaBtn.addEventListener('mouseleave', function () {
            this.style.backgroundColor = 'white';
            this.style.color = '#725AC1';
        });
    }

    // Ativar link de serviço quando clicado
    document.querySelectorAll('.service-link').forEach(link => {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            document.querySelectorAll('.service-link').forEach(l => l.classList.remove('active'));
            this.classList.add('active');
        });
    });

    // Efeito de parallax suave para a imagem do cabeçalho
    const headerImage = document.querySelector('.header-image-container');
    if (headerImage) {
        window.addEventListener('scroll', function () {
            const scrollPosition = window.pageYOffset;
            headerImage.style.transform = `translateY(${scrollPosition * 0.3}px)`;
        });
    }
});

