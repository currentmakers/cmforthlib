\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_CR_DEF
    \
    \ @brief Clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000300
    \
    $00 constant RCC_HSI16ON                    \ [0x00] 16 MHz high-speed internal clock enable
    $01 constant RCC_HSI16KERON                 \ [0x01] High-speed internal clock enable bit for some IP kernels
    $02 constant RCC_HSI16RDYF                  \ [0x02] Internal high-speed clock ready flag
    $03 constant RCC_HSI16DIVEN                 \ [0x03] HSI16DIVEN
    $04 constant RCC_HSI16DIVF                  \ [0x04] HSI16DIVF
    $05 constant RCC_HSI16OUTEN                 \ [0x05] 16 MHz high-speed internal clock output enable
    $08 constant RCC_MSION                      \ [0x08] MSI clock enable bit
    $09 constant RCC_MSIRDY                     \ [0x09] MSI clock ready flag
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable bit
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass bit
    $13 constant RCC_CSSLSEON                   \ [0x13] Clock security system on HSE enable bit
    $14 constant RCC_RTCPRE                     \ [0x14 : 2] TC/LCD prescaler
    $18 constant RCC_PLLON                      \ [0x18] PLL enable bit
    $19 constant RCC_PLLRDY                     \ [0x19] PLL clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x0000B000
    \
    $00 constant RCC_HSI16CAL                   \ [0x00 : 8] nternal high speed clock calibration
    $08 constant RCC_HSI16TRIM                  \ [0x08 : 5] High speed internal clock trimming
    $0d constant RCC_MSIRANGE                   \ [0x0d : 3] MSI clock ranges
    $10 constant RCC_MSICAL                     \ [0x10 : 8] MSI clock calibration
    $18 constant RCC_MSITRIM                    \ [0x18 : 8] MSI clock trimming
  [then]


  [ifdef] RCC_CRRCR_DEF
    \
    \ @brief Clock recovery RC register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48ON                    \ [0x00] 48MHz HSI clock enable bit
    $01 constant RCC_HSI48RDY                   \ [0x01] 48MHz HSI clock ready flag
    $02 constant RCC_HSI48DIV6EN                \ [0x02] 48 MHz HSI clock divided by 6 output enable
    $08 constant RCC_HSI48CAL                   \ [0x08 : 8] 48 MHz HSI clock calibration
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock switch
    $02 constant RCC_SWS                        \ [0x02 : 2] System clock switch status
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler
    $08 constant RCC_PPRE1                      \ [0x08 : 3] APB low-speed prescaler (APB1)
    $0b constant RCC_PPRE2                      \ [0x0b : 3] APB high-speed prescaler (APB2)
    $0f constant RCC_STOPWUCK                   \ [0x0f] Wake-up from stop clock selection
    $10 constant RCC_PLLSRC                     \ [0x10] PLL entry clock source
    $12 constant RCC_PLLMUL                     \ [0x12 : 4] PLL multiplication factor
    $16 constant RCC_PLLDIV                     \ [0x16 : 2] PLL output division
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output selection
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt flag
    $02 constant RCC_HSI16RDYIE                 \ [0x02] HSI16 ready interrupt flag
    $03 constant RCC_HSERDYIE                   \ [0x03] HSE ready interrupt flag
    $04 constant RCC_PLLRDYIE                   \ [0x04] PLL ready interrupt flag
    $05 constant RCC_MSIRDYIE                   \ [0x05] MSI ready interrupt flag
    $06 constant RCC_HSI48RDYIE                 \ [0x06] HSI48 ready interrupt flag
    $07 constant RCC_CSSLSE                     \ [0x07] LSE CSS interrupt flag
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief Clock interrupt flag register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_HSI16RDYF                  \ [0x02] HSI16 ready interrupt flag
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready interrupt flag
    $04 constant RCC_PLLRDYF                    \ [0x04] PLL ready interrupt flag
    $05 constant RCC_MSIRDYF                    \ [0x05] MSI ready interrupt flag
    $06 constant RCC_HSI48RDYF                  \ [0x06] HSI48 ready interrupt flag
    $07 constant RCC_CSSLSEF                    \ [0x07] LSE Clock Security System Interrupt flag
    $08 constant RCC_CSSHSEF                    \ [0x08] Clock Security System Interrupt flag
  [then]


  [ifdef] RCC_CICR_DEF
    \
    \ @brief Clock interrupt clear register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready Interrupt clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready Interrupt clear
    $02 constant RCC_HSI16RDYC                  \ [0x02] HSI16 ready Interrupt clear
    $03 constant RCC_HSERDYC                    \ [0x03] HSE ready Interrupt clear
    $04 constant RCC_PLLRDYC                    \ [0x04] PLL ready Interrupt clear
    $05 constant RCC_MSIRDYC                    \ [0x05] MSI ready Interrupt clear
    $06 constant RCC_HSI48RDYC                  \ [0x06] HSI48 ready Interrupt clear
    $07 constant RCC_CSSLSEC                    \ [0x07] LSE Clock Security System Interrupt clear
    $08 constant RCC_CSSHSEC                    \ [0x08] Clock Security System Interrupt clear
  [then]


  [ifdef] RCC_IOPRSTR_DEF
    \
    \ @brief GPIO reset register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IOPARST                    \ [0x00] I/O port A reset
    $01 constant RCC_IOPBRST                    \ [0x01] I/O port B reset
    $02 constant RCC_IOPCRST                    \ [0x02] I/O port A reset
    $03 constant RCC_IOPDRST                    \ [0x03] I/O port D reset
    $04 constant RCC_IOPERST                    \ [0x04] I/O port E reset
    $07 constant RCC_IOPHRST                    \ [0x07] I/O port H reset
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHB peripheral reset register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMARST                     \ [0x00] DMA reset
    $08 constant RCC_MIFRST                     \ [0x08] Memory interface reset
    $0c constant RCC_CRCRST                     \ [0x0c] Test integration module reset
    $10 constant RCC_TOUCHRST                   \ [0x10] Touch Sensing reset
    $14 constant RCC_RNGRST                     \ [0x14] Random Number Generator module reset
    $18 constant RCC_CRYPRST                    \ [0x18] Crypto module reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] System configuration controller reset
    $02 constant RCC_TIM21RST                   \ [0x02] TIM21 timer reset
    $05 constant RCC_TM12RST                    \ [0x05] TIM22 timer reset
    $09 constant RCC_ADCRST                     \ [0x09] ADC interface reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI 1 reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $16 constant RCC_DBGRST                     \ [0x16] DBG reset
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1 peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] Timer2 reset
    $01 constant RCC_TIM3RST                    \ [0x01] Timer3 reset
    $04 constant RCC_TIM6RST                    \ [0x04] Timer 6 reset
    $05 constant RCC_TIM7RST                    \ [0x05] Timer 7 reset
    $0b constant RCC_WWDRST                     \ [0x0b] Window watchdog reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $11 constant RCC_LPUART12RST                \ [0x11] UART2 reset
    $12 constant RCC_LPUART1RST                 \ [0x12] LPUART1 reset
    $13 constant RCC_USART4RST                  \ [0x13] USART4 reset
    $14 constant RCC_USART5RST                  \ [0x14] USART5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_USBRST                     \ [0x17] USB reset
    $1b constant RCC_CRSRST                     \ [0x1b] Clock recovery system reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
    $1d constant RCC_DACRST                     \ [0x1d] DAC interface reset
    $1e constant RCC_I2C3RST                    \ [0x1e] I2C3 reset
    $1f constant RCC_LPTIM1RST                  \ [0x1f] Low power timer reset
  [then]


  [ifdef] RCC_IOPENR_DEF
    \
    \ @brief GPIO clock enable register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_IOPAEN                     \ [0x00] IO port A clock enable bit
    $01 constant RCC_IOPBEN                     \ [0x01] IO port B clock enable bit
    $02 constant RCC_IOPCEN                     \ [0x02] IO port A clock enable bit
    $03 constant RCC_IOPDEN                     \ [0x03] I/O port D clock enable bit
    $04 constant RCC_IOPEEN                     \ [0x04] I/O port E clock enable bit
    $07 constant RCC_IOPHEN                     \ [0x07] I/O port H clock enable bit
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHB peripheral clock enable register
    \ Address offset: 0x30
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMAEN                      \ [0x00] DMA clock enable bit
    $08 constant RCC_MIFEN                      \ [0x08] NVM interface clock enable bit
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable bit
    $10 constant RCC_TOUCHEN                    \ [0x10] Touch Sensing clock enable bit
    $14 constant RCC_RNGEN                      \ [0x14] Random Number Generator clock enable bit
    $18 constant RCC_CRYPEN                     \ [0x18] Crypto clock enable bit
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] System configuration controller clock enable bit
    $02 constant RCC_TIM21EN                    \ [0x02] TIM21 timer clock enable bit
    $05 constant RCC_TIM22EN                    \ [0x05] TIM22 timer clock enable bit
    $07 constant RCC_MIFIEN                     \ [0x07] MiFaRe Firewall clock enable bit
    $09 constant RCC_ADCEN                      \ [0x09] ADC clock enable bit
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable bit
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable bit
    $16 constant RCC_DBGEN                      \ [0x16] DBG clock enable bit
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1 peripheral clock enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] Timer2 clock enable bit
    $01 constant RCC_TIM3EN                     \ [0x01] Timer3 clock enable bit
    $04 constant RCC_TIM6EN                     \ [0x04] Timer 6 clock enable bit
    $05 constant RCC_TIM7EN                     \ [0x05] Timer 7 clock enable bit
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable bit
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable bit
    $11 constant RCC_USART2EN                   \ [0x11] UART2 clock enable bit
    $12 constant RCC_LPUART1EN                  \ [0x12] LPUART1 clock enable bit
    $13 constant RCC_USART4EN                   \ [0x13] USART4 clock enable bit
    $14 constant RCC_USART5EN                   \ [0x14] USART5 clock enable bit
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable bit
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable bit
    $17 constant RCC_USBEN                      \ [0x17] USB clock enable bit
    $1b constant RCC_CRSEN                      \ [0x1b] Clock recovery system clock enable bit
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable bit
    $1d constant RCC_DACEN                      \ [0x1d] DAC interface clock enable bit
    $1e constant RCC_I2C3EN                     \ [0x1e] I2C3 clock enable bit
    $1f constant RCC_LPTIM1EN                   \ [0x1f] Low power timer clock enable bit
  [then]


  [ifdef] RCC_IOPSMEN_DEF
    \
    \ @brief GPIO clock enable in sleep mode register
    \ Address offset: 0x3C
    \ Reset value: 0x0000008F
    \
    $00 constant RCC_IOPASMEN                   \ [0x00] IOPASMEN
    $01 constant RCC_IOPBSMEN                   \ [0x01] IOPBSMEN
    $02 constant RCC_IOPCSMEN                   \ [0x02] IOPCSMEN
    $03 constant RCC_IOPDSMEN                   \ [0x03] IOPDSMEN
    $04 constant RCC_IOPESMEN                   \ [0x04] Port E clock enable during Sleep mode bit
    $07 constant RCC_IOPHSMEN                   \ [0x07] IOPHSMEN
  [then]


  [ifdef] RCC_AHBSMENR_DEF
    \
    \ @brief AHB peripheral clock enable in sleep mode register
    \ Address offset: 0x40
    \ Reset value: 0x01111301
    \
    $00 constant RCC_DMASMEN                    \ [0x00] DMA clock enable during sleep mode bit
    $08 constant RCC_MIFSMEN                    \ [0x08] NVM interface clock enable during sleep mode bit
    $09 constant RCC_SRAMSMEN                   \ [0x09] SRAM interface clock enable during sleep mode bit
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during sleep mode bit
    $10 constant RCC_TOUCHSMEN                  \ [0x10] Touch Sensing clock enable during sleep mode bit
    $14 constant RCC_RNGSMEN                    \ [0x14] Random Number Generator clock enable during sleep mode bit
    $18 constant RCC_CRYPSMEN                   \ [0x18] Crypto clock enable during sleep mode bit
  [then]


  [ifdef] RCC_APB2SMENR_DEF
    \
    \ @brief APB2 peripheral clock enable in sleep mode register
    \ Address offset: 0x44
    \ Reset value: 0x00405225
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] System configuration controller clock enable during sleep mode bit
    $02 constant RCC_TIM21SMEN                  \ [0x02] TIM21 timer clock enable during sleep mode bit
    $05 constant RCC_TIM22SMEN                  \ [0x05] TIM22 timer clock enable during sleep mode bit
    $09 constant RCC_ADCSMEN                    \ [0x09] ADC clock enable during sleep mode bit
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during sleep mode bit
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during sleep mode bit
    $16 constant RCC_DBGSMEN                    \ [0x16] DBG clock enable during sleep mode bit
  [then]


  [ifdef] RCC_APB1SMENR_DEF
    \
    \ @brief APB1 peripheral clock enable in sleep mode register
    \ Address offset: 0x48
    \ Reset value: 0xB8E64A11
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] Timer2 clock enable during sleep mode bit
    $01 constant RCC_TIM3SMEN                   \ [0x01] Timer3 clock enable during Sleep mode bit
    $04 constant RCC_TIM6SMEN                   \ [0x04] Timer 6 clock enable during sleep mode bit
    $05 constant RCC_TIM7SMEN                   \ [0x05] Timer 7 clock enable during Sleep mode bit
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clock enable during sleep mode bit
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clock enable during sleep mode bit
    $11 constant RCC_USART2SMEN                 \ [0x11] UART2 clock enable during sleep mode bit
    $12 constant RCC_LPUART1SMEN                \ [0x12] LPUART1 clock enable during sleep mode bit
    $13 constant RCC_USART4SMEN                 \ [0x13] USART4 clock enable during Sleep mode bit
    $14 constant RCC_USART5SMEN                 \ [0x14] USART5 clock enable during Sleep mode bit
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during sleep mode bit
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during sleep mode bit
    $17 constant RCC_USBSMEN                    \ [0x17] USB clock enable during sleep mode bit
    $1b constant RCC_CRSSMEN                    \ [0x1b] Clock recovery system clock enable during sleep mode bit
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clock enable during sleep mode bit
    $1d constant RCC_DACSMEN                    \ [0x1d] DAC interface clock enable during sleep mode bit
    $1e constant RCC_I2C3SMEN                   \ [0x1e] 2C3 clock enable during Sleep mode bit
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer clock enable during sleep mode bit
  [then]


  [ifdef] RCC_CCIPR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL0                 \ [0x00] USART1SEL0
    $01 constant RCC_USART1SEL1                 \ [0x01] USART1 clock source selection bits
    $02 constant RCC_USART2SEL0                 \ [0x02] USART2SEL0
    $03 constant RCC_USART2SEL1                 \ [0x03] USART2 clock source selection bits
    $0a constant RCC_LPUART1SEL0                \ [0x0a] LPUART1SEL0
    $0b constant RCC_LPUART1SEL1                \ [0x0b] LPUART1 clock source selection bits
    $0c constant RCC_I2C1SEL0                   \ [0x0c] I2C1SEL0
    $0d constant RCC_I2C1SEL1                   \ [0x0d] I2C1 clock source selection bits
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection bits
    $12 constant RCC_LPTIM1SEL0                 \ [0x12] LPTIM1SEL0
    $13 constant RCC_LPTIM1SEL1                 \ [0x13] Low Power Timer clock source selection bits
    $1a constant RCC_HSI48MSEL                  \ [0x1a] 48 MHz HSI48 clock source selection bit
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief Control and status register
    \ Address offset: 0x50
    \ Reset value: 0x0C000000
    \
    $00 constant RCC_LSION                      \ [0x00] Internal low-speed oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] Internal low-speed oscillator ready bit
    $08 constant RCC_LSEON                      \ [0x08] External low-speed oscillator enable bit
    $09 constant RCC_LSERDY                     \ [0x09] External low-speed oscillator ready bit
    $0a constant RCC_LSEBYP                     \ [0x0a] External low-speed oscillator bypass bit
    $0b constant RCC_LSEDRV                     \ [0x0b : 2] LSEDRV
    $0d constant RCC_CSSLSEON                   \ [0x0d] CSSLSEON
    $0e constant RCC_CSSLSED                    \ [0x0e] CSS on LSE failure detection flag
    $10 constant RCC_RTCSEL                     \ [0x10 : 2] RTC and LCD clock source selection bits
    $12 constant RCC_RTCEN                      \ [0x12] RTC clock enable bit
    $13 constant RCC_RTCRST                     \ [0x13] RTC software reset bit
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag
    $18 constant RCC_FWRSTF                     \ [0x18] : Firewall reset flag
    $19 constant RCC_OBLRSTF                    \ [0x19] OBLRSTF
    $1a constant RCC_PINRSTF                    \ [0x1a] PIN reset flag
    $1b constant RCC_PORRSTF                    \ [0x1b] POR/PDR reset flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRSTF                    \ [0x1f] Low-power reset flag
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CRRCR                \ Clock recovery RC register
  $0C constant RCC_CFGR                 \ Clock configuration register
  $10 constant RCC_CIER                 \ Clock interrupt enable register
  $14 constant RCC_CIFR                 \ Clock interrupt flag register
  $18 constant RCC_CICR                 \ Clock interrupt clear register
  $1C constant RCC_IOPRSTR              \ GPIO reset register
  $20 constant RCC_AHBRSTR              \ AHB peripheral reset register
  $24 constant RCC_APB2RSTR             \ APB2 peripheral reset register
  $28 constant RCC_APB1RSTR             \ APB1 peripheral reset register
  $2C constant RCC_IOPENR               \ GPIO clock enable register
  $30 constant RCC_AHBENR               \ AHB peripheral clock enable register
  $34 constant RCC_APB2ENR              \ APB2 peripheral clock enable register
  $38 constant RCC_APB1ENR              \ APB1 peripheral clock enable register
  $3C constant RCC_IOPSMEN              \ GPIO clock enable in sleep mode register
  $40 constant RCC_AHBSMENR             \ AHB peripheral clock enable in sleep mode register
  $44 constant RCC_APB2SMENR            \ APB2 peripheral clock enable in sleep mode register
  $48 constant RCC_APB1SMENR            \ APB1 peripheral clock enable in sleep mode register
  $4C constant RCC_CCIPR                \ Clock configuration register
  $50 constant RCC_CSR                  \ Control and status register

: RCC_DEF ; [then]
