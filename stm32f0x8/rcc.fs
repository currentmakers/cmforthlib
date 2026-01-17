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
    \ Reset value: 0x00000083
    \
    $00 constant RCC_HSION                      \ [0x00] Internal High Speed clock enable
    $01 constant RCC_HSIRDY                     \ [0x01] Internal High Speed clock ready flag
    $03 constant RCC_HSITRIM                    \ [0x03 : 5] Internal High Speed clock trimming
    $08 constant RCC_HSICAL                     \ [0x08 : 8] Internal High Speed clock Calibration
    $10 constant RCC_HSEON                      \ [0x10] External High Speed clock enable
    $11 constant RCC_HSERDY                     \ [0x11] External High Speed clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] External High Speed clock Bypass
    $13 constant RCC_CSSON                      \ [0x13] Clock Security System enable
    $18 constant RCC_PLLON                      \ [0x18] PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] PLL clock ready flag
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief Clock configuration register (RCC_CFGR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock Switch
    $02 constant RCC_SWS                        \ [0x02 : 2] System Clock Switch Status
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler
    $08 constant RCC_PPRE                       \ [0x08 : 3] APB Low speed prescaler (APB1)
    $0e constant RCC_ADCPRE                     \ [0x0e] ADC prescaler
    $0f constant RCC_PLLSRC                     \ [0x0f : 2] PLL input clock source
    $11 constant RCC_PLLXTPRE                   \ [0x11] HSE divider for PLL entry
    $12 constant RCC_PLLMUL                     \ [0x12 : 4] PLL Multiplication Factor
    $18 constant RCC_MCO                        \ [0x18 : 3] Microcontroller clock output
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller Clock Output Prescaler
    $1f constant RCC_PLLNODIV                   \ [0x1f] PLL clock not divided for MCO
  [then]


  [ifdef] RCC_CIR_DEF
    \
    \ @brief Clock interrupt register (RCC_CIR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI Ready Interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE Ready Interrupt flag
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI Ready Interrupt flag
    $03 constant RCC_HSERDYF                    \ [0x03] HSE Ready Interrupt flag
    $04 constant RCC_PLLRDYF                    \ [0x04] PLL Ready Interrupt flag
    $05 constant RCC_HSI14RDYF                  \ [0x05] HSI14 ready interrupt flag
    $06 constant RCC_HSI48RDYF                  \ [0x06] HSI48 ready interrupt flag
    $07 constant RCC_CSSF                       \ [0x07] Clock Security System Interrupt flag
    $08 constant RCC_LSIRDYIE                   \ [0x08] LSI Ready Interrupt Enable
    $09 constant RCC_LSERDYIE                   \ [0x09] LSE Ready Interrupt Enable
    $0a constant RCC_HSIRDYIE                   \ [0x0a] HSI Ready Interrupt Enable
    $0b constant RCC_HSERDYIE                   \ [0x0b] HSE Ready Interrupt Enable
    $0c constant RCC_PLLRDYIE                   \ [0x0c] PLL Ready Interrupt Enable
    $0d constant RCC_HSI14RDYE                  \ [0x0d] HSI14 ready interrupt enable
    $0e constant RCC_HSI48RDYIE                 \ [0x0e] HSI48 ready interrupt enable
    $10 constant RCC_LSIRDYC                    \ [0x10] LSI Ready Interrupt Clear
    $11 constant RCC_LSERDYC                    \ [0x11] LSE Ready Interrupt Clear
    $12 constant RCC_HSIRDYC                    \ [0x12] HSI Ready Interrupt Clear
    $13 constant RCC_HSERDYC                    \ [0x13] HSE Ready Interrupt Clear
    $14 constant RCC_PLLRDYC                    \ [0x14] PLL Ready Interrupt Clear
    $15 constant RCC_HSI14RDYC                  \ [0x15] HSI 14 MHz Ready Interrupt Clear
    $16 constant RCC_HSI48RDYC                  \ [0x16] HSI48 Ready Interrupt Clear
    $17 constant RCC_CSSC                       \ [0x17] Clock security system interrupt clear
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register (RCC_APB2RSTR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG and COMP reset
    $09 constant RCC_ADCRST                     \ [0x09] ADC interface reset
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI 1 reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 timer reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset
    $16 constant RCC_DBGMCURST                  \ [0x16] Debug MCU reset
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1 peripheral reset register (RCC_APB1RSTR)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] Timer 2 reset
    $01 constant RCC_TIM3RST                    \ [0x01] Timer 3 reset
    $04 constant RCC_TIM6RST                    \ [0x04] Timer 6 reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 timer reset
    $08 constant RCC_TIM14RST                   \ [0x08] Timer 14 reset
    $0b constant RCC_WWDGRST                    \ [0x0b] Window watchdog reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART 2 reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset
    $13 constant RCC_USART4RST                  \ [0x13] USART4 reset
    $14 constant RCC_USART5RST                  \ [0x14] USART5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_USBRST                     \ [0x17] USB interface reset
    $19 constant RCC_CANRST                     \ [0x19] CAN interface reset
    $1b constant RCC_CRSRST                     \ [0x1b] Clock Recovery System interface reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
    $1d constant RCC_DACRST                     \ [0x1d] DAC interface reset
    $1e constant RCC_CECRST                     \ [0x1e] HDMI CEC reset
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHB Peripheral Clock enable register (RCC_AHBENR)
    \ Address offset: 0x14
    \ Reset value: 0x00000014
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable
    $02 constant RCC_SRAMEN                     \ [0x02] SRAM interface clock enable
    $04 constant RCC_FLITFEN                    \ [0x04] FLITF clock enable
    $06 constant RCC_CRCEN                      \ [0x06] CRC clock enable
    $11 constant RCC_IOPAEN                     \ [0x11] I/O port A clock enable
    $12 constant RCC_IOPBEN                     \ [0x12] I/O port B clock enable
    $13 constant RCC_IOPCEN                     \ [0x13] I/O port C clock enable
    $14 constant RCC_IOPDEN                     \ [0x14] I/O port D clock enable
    $16 constant RCC_IOPFEN                     \ [0x16] I/O port F clock enable
    $18 constant RCC_TSCEN                      \ [0x18] Touch sensing controller clock enable
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register (RCC_APB2ENR)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG clock enable
    $09 constant RCC_ADCEN                      \ [0x09] ADC 1 interface clock enable
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 Timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI 1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 timer clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 timer clock enable
    $16 constant RCC_DBGMCUEN                   \ [0x16] MCU debug module clock enable
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1 peripheral clock enable register (RCC_APB1ENR)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] Timer 2 clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] Timer 3 clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] Timer 6 clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 timer clock enable
    $08 constant RCC_TIM14EN                    \ [0x08] Timer 14 clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI 2 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART 2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable
    $13 constant RCC_USART4EN                   \ [0x13] USART4 clock enable
    $14 constant RCC_USART5EN                   \ [0x14] USART5 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C 1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C 2 clock enable
    $17 constant RCC_USBRST                     \ [0x17] USB interface clock enable
    $19 constant RCC_CANEN                      \ [0x19] CAN interface clock enable
    $1b constant RCC_CRSEN                      \ [0x1b] Clock Recovery System interface clock enable
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable
    $1d constant RCC_DACEN                      \ [0x1d] DAC interface clock enable
    $1e constant RCC_CECEN                      \ [0x1e] HDMI CEC interface clock enable
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief Backup domain control register (RCC_BDCR)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] External Low Speed oscillator enable
    $01 constant RCC_LSERDY                     \ [0x01] External Low Speed oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] External Low Speed oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief Control/status register (RCC_CSR)
    \ Address offset: 0x24
    \ Reset value: 0x0C000000
    \
    $00 constant RCC_LSION                      \ [0x00] Internal low speed oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] Internal low speed oscillator ready
    $18 constant RCC_RMVF                       \ [0x18] Remove reset flag
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] PIN reset flag
    $1b constant RCC_PORRSTF                    \ [0x1b] POR/PDR reset flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHB peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $11 constant RCC_IOPARST                    \ [0x11] I/O port A reset
    $12 constant RCC_IOPBRST                    \ [0x12] I/O port B reset
    $13 constant RCC_IOPCRST                    \ [0x13] I/O port C reset
    $14 constant RCC_IOPDRST                    \ [0x14] I/O port D reset
    $16 constant RCC_IOPFRST                    \ [0x16] I/O port F reset
    $18 constant RCC_TSCRST                     \ [0x18] Touch sensing controller reset
  [then]


  [ifdef] RCC_CFGR2_DEF
    \
    \ @brief Clock configuration register 2
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PREDIV                     \ [0x00 : 4] PREDIV division factor
  [then]


  [ifdef] RCC_CFGR3_DEF
    \
    \ @brief Clock configuration register 3
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SW                   \ [0x00 : 2] USART1 clock source selection
    $04 constant RCC_I2C1SW                     \ [0x04] I2C1 clock source selection
    $06 constant RCC_CECSW                      \ [0x06] HDMI CEC clock source selection
    $07 constant RCC_USBSW                      \ [0x07] USB clock source selection
    $08 constant RCC_ADCSW                      \ [0x08] ADC clock source selection
    $10 constant RCC_USART2SW                   \ [0x10 : 2] USART2 clock source selection
  [then]


  [ifdef] RCC_CR2_DEF
    \
    \ @brief Clock control register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000080
    \
    $00 constant RCC_HSI14ON                    \ [0x00] HSI14 clock enable
    $01 constant RCC_HSI14RDY                   \ [0x01] HR14 clock ready flag
    $02 constant RCC_HSI14DIS                   \ [0x02] HSI14 clock request from ADC disable
    $03 constant RCC_HSI14TRIM                  \ [0x03 : 5] HSI14 clock trimming
    $08 constant RCC_HSI14CAL                   \ [0x08 : 8] HSI14 clock calibration
    $10 constant RCC_HSI48ON                    \ [0x10] HSI48 clock enable
    $11 constant RCC_HSI48RDY                   \ [0x11] HSI48 clock ready flag
    $18 constant RCC_HSI48CAL                   \ [0x18] HSI48 factory clock calibration
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_CFGR                 \ Clock configuration register (RCC_CFGR)
  $08 constant RCC_CIR                  \ Clock interrupt register (RCC_CIR)
  $0C constant RCC_APB2RSTR             \ APB2 peripheral reset register (RCC_APB2RSTR)
  $10 constant RCC_APB1RSTR             \ APB1 peripheral reset register (RCC_APB1RSTR)
  $14 constant RCC_AHBENR               \ AHB Peripheral Clock enable register (RCC_AHBENR)
  $18 constant RCC_APB2ENR              \ APB2 peripheral clock enable register (RCC_APB2ENR)
  $1C constant RCC_APB1ENR              \ APB1 peripheral clock enable register (RCC_APB1ENR)
  $20 constant RCC_BDCR                 \ Backup domain control register (RCC_BDCR)
  $24 constant RCC_CSR                  \ Control/status register (RCC_CSR)
  $28 constant RCC_AHBRSTR              \ AHB peripheral reset register
  $2C constant RCC_CFGR2                \ Clock configuration register 2
  $30 constant RCC_CFGR3                \ Clock configuration register 3
  $34 constant RCC_CR2                  \ Clock control register 2

: RCC_DEF ; [then]
